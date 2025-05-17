using Microsoft.AspNetCore.Mvc;

namespace WaggyProject.Controllers
{
    public class AdminLayout : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public PartialViewResult AdminLayoutNavbar()
        {
            return PartialView();
        }

        public PartialViewResult AdminLayoutSideBar()
        {
            return PartialView();
        }
    }
}
