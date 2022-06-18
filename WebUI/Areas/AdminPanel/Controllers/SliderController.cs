using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using WebUI.DAL;
using WebUI.Helpers;
using WebUI.Models;

namespace WebUI.Areas.AdminPanel.Controllers
{
    [Area("AdminPanel")]
    public class SliderController : Controller
    {

        private AppDbContext _context { get; }
        private IWebHostEnvironment _env  { get; }
        public SliderController(AppDbContext context, IWebHostEnvironment env)
        {
            _context = context;
            _env = env;
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
        public async Task<IActionResult> Create(Slider slide)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            if (!slide.Photo.CheckFileSize(200))
            {
                ModelState.AddModelError("Photo", "max size must be  less than 200kb");
                return View();
            }
            if (!slide.Photo.CheckFileType("image/"))
            {
                ModelState.AddModelError("Photo", "type file must be image");
                return View();
            }

            
            slide.URL = await slide.Photo.SaveFileAsync(_env.WebRootPath,"img");
            await _context.Slides.AddAsync(slide);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
      
        public IActionResult Update(int? id)
        {
            if (id == null)
            {
                return BadRequest();
            }
            Slider slide = _context.Slides.FirstOrDefault(s => s.ID == id);
            if (slide == null)
            {
                return NotFound();
            }
            return View(slide);
           

        }
        [HttpPost]

        [ValidateAntiForgeryToken]
        public async  Task<IActionResult> Update(int? id,Slider slide)
        {
            if (id == null)
            {
                return BadRequest();
            }
            Slider slideDb = _context.Slides.FirstOrDefault(s => s.ID == id);
            if (slide == null)
            {
                return NotFound();
            }
            //eyni addisa databaseye sorgu getmir,eyni pathdadrsa
            if (slide.Photo.FileName == slideDb.URL)
            {
                return RedirectToAction(nameof(Index));
            }
            bool isExist = _context.Slides.Any(s => s.URL == slide.Photo.FileName);
            if (isExist)
            {
                ModelState.AddModelError("Photo", $"{slide.Photo.FileName} is exist.");
                return View();
            }
            slideDb.URL = slide.Photo.FileName;
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
            //if (Helper.GetPath(_env.WebRootPath, "img", slide.URL) == slideDb.URL)
            //{
            //}
        }
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return BadRequest();
            }
            var slide = _context.Slides.Find(id);
            if (slide == null)
            {
                return NotFound();
            }
            var path=Helper.GetPath(_env.WebRootPath, "img", slide.URL);
            if (System.IO.File.Exists(path))
            {
                System.IO.File.Delete(path);
            }
            _context.Slides.Remove(slide);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));

        }       
    }
}