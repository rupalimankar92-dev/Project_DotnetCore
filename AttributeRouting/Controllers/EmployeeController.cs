using Microsoft.AspNetCore.Mvc;

namespace AttributeRouting.Controllers
{
    [Route("Employee")]
   
    public class EmployeeController : Controller
    {
        [Route("Index")]
        [Route("~/")]
        public IActionResult Index()
        {
            return View();
        }

        [Route("About")]
        [Route("~/")]
        public IActionResult About()
        {
            return View();
        }
    }
}
