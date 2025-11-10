using Microsoft.AspNetCore.Mvc;

namespace Routing_without_mvc.Controllers
{
    public class HomeController : Controller
    {
        [Route("")]
        [Route("Home")]
        [Route("Home/Index")]
        public IActionResult Index()
        {
            return View();
        }



        
        //[Route("Home/Index")]
        //public IActionResult data()
        //{
        //    return View("~/Views/Home/Index.cshtml");
        //}

        [Route("Home/About")]
        public IActionResult About()
        {
            return View();
        }
        [Route("Home/Details/{id?}")]//if id is not pass here then it takes default value  to zero (0)

        //public int Details(int id)
        //{
        //    return id ;//nullcollesc operator
        //}
        public int Details(int? id)
        {
            return id ?? 1;//nullcollesc operator if value is null then set to or return 1
        }
    }
}
