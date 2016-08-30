using System;
using Server.Framework;
using Server.Model;

namespace Server.Repository
{

    public class DossierRepository : Repository<Dossier>
    {
        public DossierRepository(string databaseFile) : base(databaseFile)
        {
        }

        public override Dossier Update(Dossier entity)
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
                Console.WriteLine("Es ist ein fehler aufgetreten. Ihre Akte konnte leider nicht aktualisiert werden." + ex);
            }
            return entity;
        }

        public override bool Delete(Dossier entity)
        {
            try
            {
                using (var session = NHibernateHelper.OpenSession())
                {
                    using (var tx = session.BeginTransaction())
                    {
                        var currentVersion = GetById(entity)?.Version;
                        entity.Version = currentVersion.Value + 1;
                        session.Delete(entity);
                        tx?.Commit();
                        return true;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Es ist ein fehler aufgetreten. Ihre Akte konnte leider nicht aktualisiert werden." + ex);
                return false;
            }
        }
    }
}
