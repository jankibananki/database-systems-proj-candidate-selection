using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;
using NHibernate.Cfg;
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

        public static NHibernate.ISession GetSession()
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
                    "Oracle connection string nije podesen. Popuni ConnectionStrings:Konekcija u appsettings.json.");

            try
            {
                var configuration = new Configuration();
                
                // Postavi Oracle driver i dialect
                configuration.SetProperty(NHibernate.Cfg.Environment.ConnectionDriver, 
                    "NHibernate.Driver.OracleManagedDataClientDriver");
                configuration.SetProperty(NHibernate.Cfg.Environment.Dialect, 
                    "NHibernate.Dialect.Oracle10gDialect");
                configuration.SetProperty(NHibernate.Cfg.Environment.ConnectionString, connectionString);
                configuration.SetProperty(NHibernate.Cfg.Environment.ShowSql, "true");

                // Učitaj mapiranja
                var mapper = new FluentNHibernate.Cfg.MappingConfiguration();
                mapper.FluentMappings.AddFromAssembly(typeof(CVMapiranja).Assembly);
                mapper.Apply(configuration);

                return configuration.BuildSessionFactory();
            }
            catch (Exception ex)
            {
                var errorMessage = GetDetailedErrorMessage(ex);
                throw new InvalidOperationException(errorMessage, ex);
            }
        }

        private static string GetDetailedErrorMessage(Exception ex)
        {
            var messages = new List<string>();
            var current = ex;
            
            while (current != null)
            {
                messages.Add($"- {current.GetType().Name}: {current.Message}");
                current = current.InnerException;
            }

            return "NHibernate konfiguracija greška:\n" + string.Join("\n", messages);
        }
    }
}
