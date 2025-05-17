using Microsoft.AspNetCore.Mvc;

namespace WaggyProject.Controllers
{
    public class UILayout : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
