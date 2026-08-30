using Microsoft.AspNetCore.Mvc;
using SelekcijaKandidataWebAPI.DTOs;

namespace SelekcijaKandidataWebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class IntervjuController : ControllerBase
    {
        [HttpGet("PreuzmiIntervjue")]
        public IActionResult PreuzmiIntervjue()
        {
            try
            {
                return new JsonResult(
                    DataProvider.VratiSveIntervjue()
                );
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }


        [HttpGet("PreuzmiIntervju/{id}")]
        public IActionResult PreuzmiIntervju(int id)
        {
            try
            {
                IntervjuView intervju =
                    DataProvider.VratiIntervju(id);

                if (intervju == null)
                    return NotFound(
                        "Intervju nije pronađen."
                    );

                return new JsonResult(intervju);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }


        [HttpPost("DodajIntervju")]
        public IActionResult DodajIntervju(
            [FromBody] IntervjuView intervju)
        {
            try
            {
                int id =
                    DataProvider.DodajIntervju(intervju);

                return Ok(new
                {
                    Poruka = "Intervju je uspešno dodat.",
                    Id = id
                });
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }


        [HttpPut("PromeniIntervju")]
        public IActionResult PromeniIntervju(
            [FromBody] IntervjuView intervju)
        {
            try
            {
                bool izmenjen =
                    DataProvider.IzmeniIntervju(
                        intervju.Id,
                        intervju
                    );

                if (!izmenjen)
                    return NotFound(
                        "Intervju nije pronađen."
                    );

                return Ok(
                    "Intervju je uspešno izmenjen."
                );
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }


        [HttpDelete("IzbrisiIntervju/{id}")]
        public IActionResult IzbrisiIntervju(int id)
        {
            try
            {
                bool obrisan =
                    DataProvider.ObrisiIntervju(id);

                if (!obrisan)
                    return NotFound(
                        "Intervju nije pronađen."
                    );

                return Ok(
                    "Intervju je uspešno obrisan."
                );
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
    }
}