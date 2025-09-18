using LAMS.Application.Interface;
using LAMS.Application.ModelViewDto;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

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
        public async Task<IActionResult> MetaDataType(int pageNumber=1, int pageSize=10, string searchTerm = "")
        {
            
            var datalist = await _metadata.getMetaDataAsync();
            var datalists = await _metadata.getAsync(pageNumber, pageSize, searchTerm);
            var ri = datalists.Data?? new List<EmployeeDataDto>();
            

            var model = new MetaDataViewModel<EmployeeDataDto>
            {
                Data = ri ,
                PageNumber = pageNumber,
                PageSize = pageSize,
                TotalRecords = datalists.Total
            };

            return View(model);
        }
        [HttpGet]
        public async Task<IActionResult> dynamicMetaDataType(int pageNumber = 1, int pageSize = 10, string searchTerm = "")
        {

            var datalist = await _metadata.getMetaDataAsync();
            var datalists = await _metadata.getAsync(pageNumber, pageSize, searchTerm);
            var ri = datalists.Data ?? new List<EmployeeDataDto>();

            return Json(new
            {
                Data = ri,
                PageNumber = pageNumber,
                PageSize = pageSize,
                TotalRecords = datalists.Total,
                TotalPages = pageSize
            });
        }
    }
}
