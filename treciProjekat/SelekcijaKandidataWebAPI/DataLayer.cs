using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;
using SelekcijaKandidata.Mapiranja;

namespace SelekcijaKandidataWebAPI
{
    public class DataLayer
    {
        private static ISessionFactory? _factory;
        private static readonly object ObjLock = new object();
        private static string? _connectionString;

        public static void Configure(string connectionString)
        {
            if (string.IsNullOrWhiteSpace(connectionString))
                throw new ArgumentException("Connection string ne sme biti prazan.", nameof(connectionString));

            lock (ObjLock)
            {
                if (_factory != null)
                    throw new InvalidOperationException("DataLayer je vec inicijalizovan.");

                _connectionString = connectionString;
            }
        }

        public static ISession GetSession()
        {
            if (_factory == null)
            {
                lock (ObjLock)
                {
                    if (_factory == null)
                        _factory = CreateSessionFactory();
                }
            }

            return _factory.OpenSession();
        }

        private static ISessionFactory CreateSessionFactory()
        {
            string connectionString = _connectionString
                ?? throw new InvalidOperationException(
                    "Oracle connection string nije podesen. Popuni ConnectionStrings:OracleBanka u appsettings.json.");

            var cfg = OracleManagedDataClientConfiguration.Oracle10
                .ShowSql()
                .ConnectionString(c => c.Is(connectionString));

            return Fluently.Configure()
                .Database(cfg)
                .Mappings(m => m.FluentMappings.AddFromAssemblyOf<CVMapiranja>())
                .BuildSessionFactory();
        }
    }
}
