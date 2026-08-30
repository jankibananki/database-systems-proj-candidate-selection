using Microsoft.AspNetCore.Http;
using SelekcijaKandidata.Entiteti;
using SelekcijaKandidataWebAPI.DTOs;

namespace SelekcijaKandidataWebAPI
{
    public class DataProvider
    {
        #region Oglasi

        public static async Task<List<OglasView>> VratiSveOglaseAsync()
        {
            NHibernate.ISession? s = null;

            try
            {
                s = DataLayer.GetSession();
                var oglasi = await s.QueryOver<Oglas>().ListAsync();
                return oglasi.Select(o => new OglasView(o)).ToList();
            }
            finally
            {
                s?.Close();
                s?.Dispose();
            }
        }

        public static async Task<StalniOglasView?> VratiStalniOglasAsync(int id)
        {
            NHibernate.ISession? s = null;

            try
            {
                s = DataLayer.GetSession();
                StalniOglas? oglas = await s.GetAsync<StalniOglas>(id);
                return oglas == null ? null : new StalniOglasView(oglas);
            }
            finally
            {
                s?.Close();
                s?.Dispose();
            }
        }

        public static async Task<PrivremeniOglasView?> VratiPrivremeniOglasAsync(int id)
        {
            NHibernate.ISession? s = null;

            try
            {
                s = DataLayer.GetSession();
                PrivremeniOglas? oglas = await s.GetAsync<PrivremeniOglas>(id);
                return oglas == null ? null : new PrivremeniOglasView(oglas);
            }
            finally
            {
                s?.Close();
                s?.Dispose();
            }
        }

        public static async Task<SezonskiOglasView?> VratiSezonskiOglasAsync(int id)
        {
            NHibernate.ISession? s = null;

            try
            {
                s = DataLayer.GetSession();
                SezonskiOglas? oglas = await s.GetAsync<SezonskiOglas>(id);
                return oglas == null ? null : new SezonskiOglasView(oglas);
            }
            finally
            {
                s?.Close();
                s?.Dispose();
            }
        }

        public static async Task<PraksaView?> VratiPraksuAsync(int id)
        {
            NHibernate.ISession? s = null;

            try
            {
                s = DataLayer.GetSession();
                Praksa? oglas = await s.GetAsync<Praksa>(id);
                return oglas == null ? null : new PraksaView(oglas);
            }
            finally
            {
                s?.Close();
                s?.Dispose();
            }
        }

        #endregion
    }
}
