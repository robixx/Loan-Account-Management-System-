using Microsoft.AspNetCore.Mvc;

namespace LAMS.WEB.Areas.Security.Controllers
{
    [Area("Security")]
    public class SecurityController : Controller
    {



        [HttpGet]
        public IActionResult CustomerProfile()
        {
            return View();
        }
    }
}
