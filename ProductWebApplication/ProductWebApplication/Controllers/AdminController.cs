using Microsoft.AspNetCore.Mvc;

namespace ProductWebApplication.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(int id,String pass)
        {
            if(id==1 && pass=="r@123")
            {
                return RedirectToAction("Details","Product");
            }
            return View();
        }
    }
}
