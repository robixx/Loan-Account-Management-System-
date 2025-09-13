using Microsoft.AspNetCore.Mvc;

namespace LAMS.WEB.Areas.Accounts.Controllers
{
    [Area("Accounts")]
    public class AccountsController : Controller
    {

        [HttpGet]
        public IActionResult CustomerCreate()
        {
            return View();
        }
    }
}
