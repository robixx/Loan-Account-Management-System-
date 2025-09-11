using Microsoft.AspNetCore.Mvc;

namespace LAMS.WEB.Areas.Dashboard.Controllers
{
    [Area("Dashboard")]
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
