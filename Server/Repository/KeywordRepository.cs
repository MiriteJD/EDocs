using System;
using System.Linq;
using NHibernate;
using NHibernate.Criterion;
using Server.Framework;
using Server.Model;

namespace Server.Repository
{
    /// <summary>
    /// Klasse für die Steuerung der Zugriffe auf Kategorien in der Datenbank.
    /// </summary>
    public class KeywordRepository : Repository<Keyword>
    {
        private static object _mStaticLock = new object();

        public KeywordRepository(string databaseFile) : base(databaseFile)
        {
        }

        #region Save keyword

        /// <summary>
        /// Speichert eine Kategorie in die Datenbank.
        /// Implementiert mittels Optimistic Locking.
        /// </summary>
        /// <param name="keyword"></param>
        /// <returns></returns>
        public override Keyword Save(Keyword keyword)
        {
            var categorySaved = OptimisticSave(keyword);
            if (!categorySaved)
            {
                LockSave(keyword);
            }
            return keyword;

        }

        /// <summary>
        /// Prüft ob Kategorie mit gleicher Benennung in der Datenbank vorhanden ist.
        /// </summary>
        /// <param name="keyword"></param>
        /// <returns></returns>
        public bool CanSave(Keyword keyword)
        {

            using (var session = NHibernateHelper.OpenSession())
            {
                var returnList =
                    session.CreateCriteria<Keyword>()
                        .Add(Restrictions.Eq("Name", keyword.Name))
                        .List<Keyword>();
                if (returnList.Count == 0)
                {
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// Versucht nach Optimistic Locking Pattern die Kategorie in die Datenbank zu schreiben.
        /// Rückgabe true, wenn der Eintrag in die Datenbank geschrieben werden konnte.
        /// </summary>
        /// <param name="keyword"></param>
        /// <returns></returns>
        public bool OptimisticSave(Keyword keyword)
        {
            var originName = keyword.Name;
            try
            {
                var nameIndex = 1;

                while (!CanSave(keyword))
                {
                    keyword.Name = string.Concat(originName, $"({nameIndex++})");
                }

                using (var session = NHibernateHelper.OpenSession())
                {
                    using (var transaction = session.BeginTransaction())
                    {
                        if (!CanSave(keyword))
                            return false;

                        session.Save(keyword);
                        transaction.Commit();
                        return true;
                    }
                }
            }
            catch (Exception e)
            {
                keyword.Name = originName;
                return false;
            }

        }

        /// <summary>
        /// Schreibt die Kategorie in die Datenbank.
        /// Lockt die gesamte Tabelle 'Categories' während des Speichervorgangs.
        /// </summary>
        /// <param name="category"></param>
        public void LockSave(Keyword category)
        {

            using (var session = NHibernateHelper.OpenSession())
            {
                using (var transaction = session.BeginTransaction())
                {
                    try
                    {
                        //Lockt gesamte 'Categories' Tabelle um Kategorienamen abzugleichen
                        session.CreateSQLQuery("SELECT * FROM Categories WITH (tablockx, holdlock)").AddScalar("Id", NHibernateUtil.Int32);

                        var originName = category.Name;
                        var nameIndex = 1;

                        while (!CanSave(category))
                        {
                            category.Name = string.Concat(originName, $"({nameIndex++})");
                        }

                        session.Save(category);
                        transaction.Commit();
                    }
                    catch (Exception e)
                    {
                        transaction.Rollback();
                        Console.Write("'Save Category' transaction failed.");
                        Console.WriteLine(e.Message);
                    }
                }
            }

        }
        #endregion

        #region Delete keyword

        /// <summary>
        /// Löscht eine Kategorie asu der Datenbank.
        /// Implementiert mittels Optimistic Locking.
        /// </summary>
        /// <param name="keyword"></param>
        /// <returns></returns>
        public override bool Delete(Keyword keyword)
        {
            try
            {
                if (OptimisticDelete(keyword))
                    return true;
                return LockDelete(keyword);
            }
            catch (Exception e)
            {
                Console.WriteLine("Beim Löschen der Kategorie ist ein Fehler aufgetreten.");
                Console.WriteLine(e.Message);
                return false;
            }

        }

        /// <summary>
        /// Versucht nach Optimistic Locking Pattern die Kategorie aus der Datenbank zu löschen.
        /// Rückgabe true, wenn der Eintrag asu der Datenbank gelöscht werden konnte.
        /// </summary>
        /// <param name="keyword"></param>
        /// <returns></returns>
        public bool OptimisticDelete(Keyword keyword)
        {
            using (var session = NHibernateHelper.OpenSession())
            {
                var tx = session.BeginTransaction();

                keyword.Version = keyword.Version + 1;
                session.Delete(keyword);
                var currentVersion = GetById(keyword)?.Version;
                if (keyword.Version > currentVersion && TaskRelationsCleared(keyword))
                {
                    tx?.Commit();
                    return true;
                }
                else
                {
                    tx?.Rollback();
                    return false;
                }
            }
        }

        public bool LockDelete(Keyword keyword)
        {
            using (var session = NHibernateHelper.OpenSession())
            {
                using (var tx = session.BeginTransaction())
                {
                    session.Lock(keyword, LockMode.Upgrade);
                    if (!TaskRelationsCleared(keyword))
                        return false;

                    var currentVersion = GetById(keyword)?.Version;
                    if (currentVersion == null)
                        return false;
                    keyword.Version = currentVersion.Value + 1;

                    session.Delete(keyword);
                    tx?.Commit();
                    return true;
                }
            }
        }

      
        public bool TaskRelationsCleared(Keyword keyword)
        {
            try
            {

                using (var session = NHibernateHelper.OpenSession())
                {
                    var returnList =
                        session.CreateCriteria<Keyword>()
                            .Add(Restrictions.Eq("Id", keyword.Id))
                            .List<Keyword>();
                    if (returnList.Count != 1)
                        return false;

                    var kewrd = returnList.FirstOrDefault();
                    if (kewrd?.Documents?.Count != 0)
                        return false;
                    return true;

                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Beim Löschen der Kategorie ist ein Fehler aufgetreten.");
                Console.WriteLine(e.Message);
                return false;
            }
        }

        #endregion

    }
}

