using Microsoft.AspNetCore.Mvc;
using WebSite.Models;

namespace WebSite.Controllers
{
    public class handlerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Check(IndexModel indexModel)
        {
            if (ModelState.IsValid)
                    return View("AfterRegistr");

            return View("AfterRegistr");
        }
    }
}
