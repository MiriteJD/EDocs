using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using NHibernate.Criterion;
using Server.Model;

namespace Server.Framework
{
    public class Repository<T> where T : BaseModel
    {
        public Repository(string databaseFile)
        {
            NHibernateHelper.DatabaseFile = databaseFile;
        }



        public List<T> GetAll()
        {
            using (var session = NHibernateHelper.OpenSession())
            {
                var returnList = session.CreateCriteria<T>().List<T>();
                return returnList as List<T>;
            }
        }


        public virtual bool Delete(T entity)
        {
            try
            {
                using (var session = NHibernateHelper.OpenSession())
                {
                    using (var transaction = session.BeginTransaction())
                    {
                        session.Delete(entity);
                        transaction.Commit();
                        return true;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Es ist ein Fehler aufgetreten. Es konnte nicht gelöscht werden. " + ex);
                return false;
            }
        }

        public virtual T Save(T entity)
        {
            try
            {
                using (var session = NHibernateHelper.OpenSession())
                {
                    using (var transaction = session.BeginTransaction())
                    {
                        session.Save(entity);
                        transaction.Commit();
                    }
                }
            }
            catch (Exception ex)
            {
                Trace.WriteLine("Es ist ein Fehler aufgetreten. Es konnte nicht gespeichert werden. " + ex);
            }
            return entity;
        }

        public T GetById(int entity)
        {
            using (var session = NHibernateHelper.OpenSession())
            {
                var returnList = session.CreateCriteria<T>().Add(Restrictions.Eq("Id", entity)).List<T>();
                var returnEntity = returnList?.FirstOrDefault();
                return returnEntity;
            }
        }


        public T GetById(T entity)
        {
            using (var session = NHibernateHelper.OpenSession())
            {
                var returnList = session.CreateCriteria<T>().Add(Restrictions.Eq("Id", entity.Id)).List<T>();
                var returnEntity = returnList?.FirstOrDefault();
                return returnEntity;
            }
        }

        public virtual T Update(T entity)
        {
            try
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

                return entity;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Es ist ein Fehler aufgetreten. Es konnte nicht geupdatet werden. " + ex);
            }
            return entity;
        }
    }
}