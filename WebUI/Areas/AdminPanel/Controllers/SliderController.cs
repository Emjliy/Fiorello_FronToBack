using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
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
            using (
                FileStream filestream = new FileStream(@"C: \Users\Emilia\Desktop\Fiorella\img\" + slide.Photo.FileName, FileMode.Create))
            {
                slide.Photo.CopyTo(filestream);
            }
                return Json(slide.Photo.FileName);

        }
        //[HttpPost]

        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> Upload(int? id, Slider slide)
        //{
        //    if (id == null)
        //    {
        //        return BadRequest();
        //    }
        //    Slider slideDb = _context.Slides.FirstOrDefault(s => s.ID == id);
        //    if (slide == null)
        //    {
        //        return NotFound();
        //    }
        //    if (slide.Photo.FileName == slideDb.Photo.FileName)
        //    {
        //        return RedirectToAction(nameof(Index));
        //    }
        //    else
        //    {

        //    }
        //    bool isExist = Slider.Any(s => s.pho.ToLower() == slide.Photo.FileName.ToLower());
        //    if (isExist)
        //    {
        //        ModelState.AddModelError("Photo", $"{slide.Photo.FileName} is exist.");
        //        return View();
        //    }
        //    slideDb.Photo.FileName = slide.Photo.FileName;
        //    await _context.SaveChangesAsync();
        //    return RedirectToAction(nameof(Index));

        //}

    }
}