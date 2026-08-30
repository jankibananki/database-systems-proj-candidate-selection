using Microsoft.AspNetCore.Mvc;
using SelekcijaKandidataWebAPI.DTOs;

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

        [HttpPost("DodajStalniOglas")]
        public async Task<IActionResult> DodajStalniOglas([FromBody] StalniOglasView oglas)
        {
            try 
            {
                await DataProvider.DodajStalniOglasAsync(oglas);
                return Ok(oglas); 
            }
            catch (Exception ex) 
            { 
                return BadRequest(ex.Message); 
            }
        }

        [HttpPost("DodajPrivremeniOglas")]
        public async Task<IActionResult> DodajPrivremeniOglas([FromBody] PrivremeniOglasView oglas)
        {
            try 
            { 
                await DataProvider.DodajPrivremeniOglasAsync(oglas); 
                return Ok(oglas);
            }
            catch (Exception ex) 
            { 
                return BadRequest(ex.Message); 
            }
        }

        [HttpPost("DodajSezonskiOglas")]
        public async Task<IActionResult> DodajSezonskiOglas([FromBody] SezonskiOglasView oglas)
        {
            try 
            { 
                await DataProvider.DodajSezonskiOglasAsync(oglas); 
                return Ok(oglas);
            }
            catch (Exception ex) 
            {
                return BadRequest(ex.Message); 
            }
        }

        [HttpPost("DodajPraksu")]
        public async Task<IActionResult> DodajPraksu([FromBody] PraksaView oglas)
        {
            try 
            { 
                await DataProvider.DodajPraksuAsync(oglas); 
                return Ok(oglas); 
            }
            catch (Exception ex)
            { 
                return BadRequest(ex.Message); 
            }
        }

        [HttpDelete("DeleteOglas/{id}")]
        public async Task<IActionResult> DeleteOglas(int id)
        {
            try 
            { 
                await DataProvider.ObrisiOglasAsync(id); 
                return Ok(); 
            }
            catch (Exception ex) 
            { 
                return BadRequest(ex.Message); 
            }
        }


        [HttpPut("IzmeniStalniOglas")]
        public async Task<IActionResult> IzmeniStalniOglas([FromBody] StalniOglasView item)
        {
            try 
            { 
                await DataProvider.IzmeniStalniOglasAsync(item); 
                return Ok(); 
            }
            catch (Exception ex) 
            { 
                return BadRequest(ex.Message); 
            }
        }

        [HttpPut("IzmeniPrivremeniOglas")]
        public async Task<IActionResult> IzmeniPrivremeniOglas([FromBody] PrivremeniOglasView item)
        {
            try 
            {
                await DataProvider.IzmeniPrivremeniOglasAsync(item);
                return Ok(); 
            }
            catch (Exception ex) 
            { 
                return BadRequest(ex.Message); 
            }
        }

        [HttpPut("IzmeniSezonskiOglas")]
        public async Task<IActionResult> IzmeniSezonskiOglas([FromBody] SezonskiOglasView item)
        {
            try 
            { 
                await DataProvider.IzmeniSezonskiOglasAsync(item);
                return Ok();
            }
            catch (Exception ex) 
            { 
                return BadRequest(ex.Message);
            }
        }

        [HttpPut("IzmeniPraksu")]
        public async Task<IActionResult> IzmeniPraksu([FromBody] PraksaView item)
        {
            try 
            { 
                await DataProvider.IzmeniPraksuAsync(item); 
                return Ok(); 
            }
            catch (Exception ex) 
            { 
                return BadRequest(ex.Message);
            }
        }

    }
}
