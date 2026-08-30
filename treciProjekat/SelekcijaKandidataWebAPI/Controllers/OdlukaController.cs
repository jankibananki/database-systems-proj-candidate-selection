using Microsoft.AspNetCore.Mvc;

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
    }
}
