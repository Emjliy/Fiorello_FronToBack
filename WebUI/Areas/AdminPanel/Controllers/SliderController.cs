using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebUI.DAL;
using WebUI.Models;

namespace WebUI.Areas.AdminPanel.Controllers
{
    [Area("AdminPanel")]
    public class SliderController : Controller
    {

        private AppDbContext _context { get; }
        public SliderController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View(_context.Slides);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Slider slide)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            if (slide.Photo.Length / 1024 > 200)
            {
                ModelState.AddModelError("Photo", "max size must be  less than 200kb");
                return View();
            }

            if (!(slide.Photo.ContentType.Contains("image/")))
            {
                ModelState.AddModelError("Photo", "type file must be image");
                return View();
            }
            return Json(slide.Photo.FileName);

            //await _context.Categories.AddAsync(newCategory);
            //await _context.SaveChangesAsync();
            //return RedirectToAction(nameof(Index));
        }

    }
}