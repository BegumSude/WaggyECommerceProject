using Microsoft.AspNetCore.Mvc;
using WaggyProject.Context;
using WaggyProject.Entities;

namespace WaggyProject.Controllers
{
    public class DefaultController : Controller
    {
        private readonly WaggyContext _context; // Dependency injection for WaggyContext (field türettik burda)

        public DefaultController(WaggyContext context)
        {
            _context = context;  //bu field'in hangi sınıfın bir nesnesine karşılık geldiğini constructor içinde belirtiyoruz.
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SendMessage(Message model)
        {
            _context.Add(model);
            _context.SaveChanges();
            return NoContent();
        }
    }
}
