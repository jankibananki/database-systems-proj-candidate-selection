using Microsoft.AspNetCore.Mvc;

namespace SelekcijaKandidataWebAPI.Controllers
{
    public class OglasController : Controller
    {
        [HttpGet("GetOglasi")]
        public async Task<IActionResult> GetOglasi()
        {
            try
            {
                return Ok(await DataProvider.VratiSveOglaseAsync());
            }
            catch (Exception ex) 
            { 
                return BadRequest(ex.Message); 
            }
        }

        [HttpGet("GetStalniOglas/{id}")]
        public async Task<IActionResult> GetStalniOglas(int id)
        {
            try
            {
                var oglas = await DataProvider.VratiStalniOglasAsync(id);
                return oglas == null ? NotFound() : Ok(oglas);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message); 
            }
        }

        [HttpGet("GetPrivremeniOglas/{id}")]
        public async Task<IActionResult> GetPrivremeniOglas(int id)
        {
            try
            {
                var oglas = await DataProvider.VratiPrivremeniOglasAsync(id);
                return oglas == null ? NotFound() : Ok(oglas);
            }
            catch (Exception ex) 
            { 
                return BadRequest(ex.Message); 
            }
        }

        [HttpGet("GetSezonskiOglas/{id}")]
        public async Task<IActionResult> GetSezonskiOglas(int id)
        {
            try
            {
                var oglas = await DataProvider.VratiSezonskiOglasAsync(id);
                return oglas == null ? NotFound() : Ok(oglas);
            }
            catch (Exception ex) 
            { 
                return BadRequest(ex.Message); 
            }
        }

        [HttpGet("GetPraksa/{id}")]
        public async Task<IActionResult> GetPraksa(int id)
        {
            try
            {
                var oglas = await DataProvider.VratiPraksuAsync(id);
                return oglas == null ? NotFound() : Ok(oglas);
            }
            catch (Exception ex) 
            { 
                return BadRequest(ex.Message); 
            }
        }
    }
}
