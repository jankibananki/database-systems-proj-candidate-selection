using Microsoft.AspNetCore.Mvc;
using SelekcijaKandidataWebAPI.DTOs;

namespace SelekcijaKandidataWebAPI.Controllers
{
    public class ZahteviOglasController : Controller
    {
        [HttpGet("GetZahtevi/{idOglasa}")]
        public async Task<IActionResult> GetZahtevi(int idOglasa)
        {
            try
            {
                return Ok(await DataProvider.VratiZahteveAsync(idOglasa));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost("DodajZahtev/{idOglasa}")]
        public async Task<IActionResult> DodajZahtev(int idOglasa, [FromBody] string tekst)
        {
            try
            {
                await DataProvider.DodajZahtevAsync(idOglasa, tekst);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete("DeleteZahtev/{idOglasa}")]
        public async Task<IActionResult> DeleteZahtev(int idOglasa, [FromQuery] string tekst)
        {
            try
            {
                await DataProvider.ObrisiZahtevAsync(idOglasa, tekst);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut("IzmeniZahtev/{idOglasa}")]
        public async Task<IActionResult> IzmeniZahtev(int idOglasa, [FromBody] PromeniZahtevView model)
        {
            try
            {
                await DataProvider.PromeniZahtevAsync(idOglasa, model.StariTekst, model.NoviTekst);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
