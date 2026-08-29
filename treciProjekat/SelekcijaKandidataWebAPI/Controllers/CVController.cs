using Microsoft.AspNetCore.Mvc;

namespace SelekcijaKandidataWebAPI.Controllers
{
    public class CVController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
