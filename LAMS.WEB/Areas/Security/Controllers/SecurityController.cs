using LAMS.Application.Interface;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace LAMS.WEB.Areas.Security.Controllers
{
    [Area("Security")]
    public class SecurityController : Controller
    {

        private readonly IMetaData _metadata;
        public SecurityController(IMetaData metaData)
        {
            _metadata = metaData;
        }

        [HttpGet]
        public IActionResult CustomerProfile()
        {
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> MetaDataType()
        {
            var datalist = await _metadata.getMetaDataAsync();

            return View();
        }
    }
}
