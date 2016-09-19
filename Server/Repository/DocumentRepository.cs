using System;
using Server.Framework;
using Server.Model;

namespace Server
{
    public class DocumentRepository : Repository<Document>
    {
        private static readonly object _mStaticLock = new object();

        public DocumentRepository(string databaseFile) : base(databaseFile)
        {
        }

       
        public override Document Update(Document entity)
        {
            try
            {
                //Optimistic Update
                using (var session = NHibernateHelper.OpenSession())
                {
                    using (var transaction = session.BeginTransaction())
                    {
                        entity.Version = entity.Version + 1;
                        session.Update(entity);
                        var currentVersion = GetById(entity)?.Version;
                        if (entity.Version > currentVersion)
                        {
                            transaction?.Commit();
                            return entity;
                        }
                        else
                        {
                            transaction?.Rollback();
                        }
                    }
                }
                //Hardlock für Update, wenn Optimistic Update fehlgeschlagen ist
                lock (_mStaticLock)
                {
                    using (var session = NHibernateHelper.OpenSession())
                    {
                        using (var transaction = session.BeginTransaction())
                        {
                            var currentVersion = GetById(entity)?.Version;
                            entity.Version = currentVersion.Value + 1;
                            session.Update(entity);
                            transaction?.Commit();
                        }
                    }
                }
                return entity;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Es ist ein fehler aufgetreten. Ihr Dokument konnte leider nicht aktualisiert werden."+ex);

            }
            return entity;
        }

       
        public override bool Delete(Document entity)
        {
            try
            {
                //Optimistic Delete
                using (var session = NHibernateHelper.OpenSession())
                {
                    using (var transaction = session.BeginTransaction())
                    {
                        entity.Version = entity.Version + 1;
                        session.Delete(entity);
                        var currentVersion = GetById(entity)?.Version;
                        if (entity.Version > currentVersion)
                        {
                            transaction?.Commit();
                        }
                        else
                        {
                            transaction?.Rollback();
                        }
                    }

                }
                //Hardlock für Delete, wenn Optimistic Update fehlgeschlagen ist
                lock (_mStaticLock)
                {
                    using (var session = NHibernateHelper.OpenSession())
                    {
                        using (var transaction = session.BeginTransaction())
                        {
                            var currentVersion = GetById(entity)?.Version;
                            if (currentVersion == null)
                            {
                                //TODO: cannot delete ---> iwo überprüfen?
                            }
                            entity.Version = currentVersion.Value + 1;
                            session.Delete(entity);
                            transaction?.Commit();
                            return true;
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("Es ist ein fehler aufgetreten. Ihr Dokument konnte leider nicht gelöscht werden."+ex);
                Console.ReadLine();
                return false;
            }
        }

    }
}
