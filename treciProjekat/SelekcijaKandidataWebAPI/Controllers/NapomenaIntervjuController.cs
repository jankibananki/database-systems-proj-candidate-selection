using Microsoft.AspNetCore.Mvc;
using SelekcijaKandidataWebAPI.DTOs;

namespace SelekcijaKandidataWebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class NapomenaIntervjuController : ControllerBase
    {
        [HttpGet("PreuzmiNapomene/{idIntervjua}")]
        public IActionResult PreuzmiNapomene(
            int idIntervjua)
        {
            try
            {
                return new JsonResult(
                    DataProvider.VratiNapomeneIntervjua(
                        idIntervjua
                    )
                );
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }


        [HttpPost("DodajNapomenu")]
        public IActionResult DodajNapomenu(
            [FromBody] NapomenaIntervjuView napomena)
        {
            try
            {
                bool dodata =
                    DataProvider.DodajNapomenu(napomena);

                if (!dodata)
                    return NotFound(
                        "Intervju nije pronađen."
                    );

                return Ok(
                    "Napomena je uspešno dodata."
                );
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }


        [HttpPut("PromeniNapomenu")]
        public IActionResult PromeniNapomenu(
            [FromQuery] string staraNapomena,
            [FromBody] NapomenaIntervjuView napomena)
        {
            try
            {
                bool izmenjena =
                    DataProvider.IzmeniNapomenu(
                        napomena.IdIntervjua,
                        staraNapomena,
                        napomena.Napomena
                    );

                if (!izmenjena)
                    return NotFound(
                        "Napomena nije pronađena."
                    );

                return Ok(
                    "Napomena je uspešno izmenjena."
                );
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }


        [HttpDelete(
            "IzbrisiNapomenu/{idIntervjua}")]
        public IActionResult IzbrisiNapomenu(
            int idIntervjua,
            [FromQuery] string napomena)
        {
            try
            {
                bool obrisana =
                    DataProvider.ObrisiNapomenu(
                        idIntervjua,
                        napomena
                    );

                if (!obrisana)
                    return NotFound(
                        "Napomena nije pronađena."
                    );

                return Ok(
                    "Napomena je uspešno obrisana."
                );
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
    }
}