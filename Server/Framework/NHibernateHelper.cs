using System;
using System.Reflection;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;

namespace Server.Framework
{
	public static class NHibernateHelper
	{
		private static ISessionFactory _mSessionFactory;

		public static string DatabaseFile { get; set; }

		public static ISession OpenSession()
		{
			return SessionFactory.OpenSession();
		}

		private static ISessionFactory SessionFactory
		{
			get
			{
				if (_mSessionFactory == null)
					InitializeSessionFactory();

				return _mSessionFactory;
			}
		}

		private static void InitializeSessionFactory()
		{
            try
            {
                _mSessionFactory = Fluently.Configure()
                        .Database(SQLiteConfiguration.Standard.UsingFile(DatabaseFile).ShowSql())
                        .Mappings(m => m.FluentMappings.AddFromAssembly(Assembly.GetExecutingAssembly())
                        .Conventions.Add(FluentNHibernate.Conventions.Helpers.DefaultLazy.Never()))
                        .BuildSessionFactory();
            }
            catch (System.Exception ex)
            {
                Console.WriteLine(ex);
                throw;
            }
		}
	}
}