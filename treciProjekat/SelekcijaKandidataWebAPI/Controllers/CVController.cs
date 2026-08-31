using Microsoft.AspNetCore.Mvc;
using SelekcijaKandidataWebAPI.DTOs;

namespace SelekcijaKandidataWebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CVController : ControllerBase
    {
        [HttpGet("PreuzmiCVeve")]
        public IActionResult PreuzmiCVeve()
        {
            try
            {
                return new JsonResult(
                    DataProvider.VratiSveCV()
                );
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }


        [HttpGet("PreuzmiCV/{id}")]
        public IActionResult PreuzmiCV(int id)
        {
            try
            {
                CVView cv = DataProvider.VratiCV(id);

                if (cv == null)
                    return NotFound("CV nije pronađen.");

                return new JsonResult(cv);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }


        [HttpPost("DodajCV")]
        public IActionResult DodajCV([FromBody] CVView cv)
        {
            try
            {
                int id = DataProvider.DodajCV(cv);

                return Ok(new
                {
                    Poruka = "CV je uspešno dodat.",
                    Id = id
                });
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }


        [HttpPut("PromeniCV")]
        public IActionResult PromeniCV([FromBody] CVView cv)
        {
            try
            {
                bool izmenjen =
                    DataProvider.IzmeniCV(cv.Id, cv);

                if (!izmenjen)
                    return NotFound("CV nije pronađen.");

                return Ok("CV je uspešno izmenjen.");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }


        [HttpDelete("IzbrisiCV/{id}")]
        public IActionResult IzbrisiCV(int id)
        {
            try
            {
                bool obrisan =
                    DataProvider.ObrisiCV(id);

                if (!obrisan)
                    return NotFound("CV nije pronađen.");

                return Ok("CV je uspešno obrisan.");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
    }
}