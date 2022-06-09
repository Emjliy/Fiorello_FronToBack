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
            return Content("Ok");
            
            //await _context.Categories.AddAsync(newCategory);
            //await _context.SaveChangesAsync();
            //return RedirectToAction(nameof(Index));
        }

    }
}