using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;
using SelekcijaKandidata.Mapiranja;
using System;

namespace SelekcijaKandidata
{
    internal class DataLayer
    {
        private static ISessionFactory _factory = null;
        private static object objLock = new object();

        public static ISession GetSession()
        {
            if (_factory == null)
            {
                lock (objLock)
                {
                    if (_factory == null)
                        _factory = CreateSessionFactory();
                }
            }

            return _factory.OpenSession();
        }

        private static ISessionFactory CreateSessionFactory()
        {
            try
            {
                var cfg = OracleManagedDataClientConfiguration.Oracle10
                .ShowSql()
                .ConnectionString(c =>
                    c.Is("Data Source=gislab-oracle.elfak.ni.ac.rs:1521/SBP_PDB;User Id=S19583;Password=lozinka123"));

                return Fluently.Configure()
                    .Database(cfg)
                    .Mappings(m => m.FluentMappings.AddFromAssemblyOf<CVMapiranja>())
                    .BuildSessionFactory();
            }
            catch (Exception ec)
            {
                System.Windows.Forms.MessageBox.Show(ec.ToString(), "Nhibernate greska");
                throw;
            }
        }
    }
}
