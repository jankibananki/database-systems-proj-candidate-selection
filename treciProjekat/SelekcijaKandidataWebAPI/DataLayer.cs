using NHibernate;

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
    }
}
