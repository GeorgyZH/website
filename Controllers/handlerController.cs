using Microsoft.AspNetCore.Mvc;
using WebSite.Models;

namespace WebSite.Controllers
{
    public class HandlerController : Controller
    {
        public IActionResult AfterRegistr()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Check(IndexModel indexModel)
        {
            if (ModelState.IsValid)
                return Redirect("AfterRegistr");

            return Redirect("/");
        }
    }
}
