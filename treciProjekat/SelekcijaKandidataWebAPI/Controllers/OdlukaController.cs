using Microsoft.AspNetCore.Mvc;
using SelekcijaKandidataWebAPI.DTOs;

namespace SelekcijaKandidataWebAPI.Controllers
{
    public class OdlukaController : Controller
    {
        [HttpGet("GetSveOdluke")]
        public async Task<IActionResult> GetSveOdluke()
        {
            try
            { 
                return Ok(await DataProvider.VratiSveOdlukeAsync());
            }
            catch (Exception ex) 
            {
                return BadRequest(ex.Message); 
            }
        }

        [HttpGet("GetOdluka/{id}")]
        public async Task<IActionResult> GetOdluka(int id)
        {
            try
            {
                var odluka = await DataProvider.VratiOdlukuAsync(id);
                return odluka == null ? NotFound() : Ok(odluka);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message); 
            }
        }

        [HttpPut("IzmeniOdluku")]
        public async Task<IActionResult> IzmeniOdluku([FromBody] OdlukaView odluka)
        {
            try 
            { 
                await DataProvider.IzmeniOdlukuAsync(odluka); 
                return Ok(); 
            }
            catch (Exception ex) 
            { 
                return BadRequest(ex.Message); 
            }
        }

        [HttpDelete("DeleteOdluka/{id}")]
        public async Task<IActionResult> DeleteOdluka(int id)
        {
            try 
            { 
                await DataProvider.ObrisiOdlukuAsync(id); 
                return Ok(); 
            }
            catch (Exception ex) 
            { 
                return BadRequest(ex.Message); 
            }
        }
    }
}
