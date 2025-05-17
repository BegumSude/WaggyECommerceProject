using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WaggyProject.Context;
using WaggyProject.Entities;

namespace WaggyProject.Controllers
{
    [Authorize]
    public class TestimonialController(WaggyContext _context) : Controller //controller sınıfından miras alıyor //private readonly demeden PRIMARY CONSTRUCTOR ŞEKLİNDE YAPILABİLİR
    {

        public IActionResult Index()
        {
            var values = _context.Testimonials.ToList(); //veritabanından verileri alıyoruz
            return View(values);
        }

        public IActionResult DeleteTestimonial(int id)
        {
            var value = _context.Testimonials.Find(id);
            _context.Remove(value);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult AddTestimonial()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddTestimonial(Testimonial model)
        {

            //Fast Fail Yöntemi (ilk önce hataları yakala sonra işlemleri yap)

            if (!ModelState.IsValid)
            {
                return View(model);
            }

            _context.Add(model);
            _context.SaveChanges();
            return RedirectToAction("Index");

        }

        public IActionResult UpdateTestimonial()
        {
            return View();
        }

        [HttpPost]
        public IActionResult UpdateTestimonial(Testimonial model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            _context.Update(model);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
