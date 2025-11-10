using Microsoft.AspNetCore.Mvc;

namespace AttributeRouting.Controllers
{
    //token
    [Route("[Controller]")]

    //[Route("[Controller]/[action]")]
   
    public class StudentController : Controller
    {
        [Route("[action]")]
        [Route("~/Home")]
        public IActionResult Index()
        {
            return View();
        }

        [Route("[action]/{id?}")]
        public int Details(int? id)
        {
            return id ?? 1;//nullcollesc operator if value is null then set to or return 1
        }
    }
}

    