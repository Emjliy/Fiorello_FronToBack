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
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> Create(Slider slide)
        //{
        //if (!ModelState.IsValid) return View();
        //bool isExist = false;
        //foreach (var ct in categories)
        //{
        //    if (category.Name.ToLower() == ct.Name.ToLower())
        //    {
        //        isExist = true; break;
        //    }
        //}
        //if (isExist)
        //{
        //    ModelState.AddModelError("NAME", $"{category.Name} is exist.");
        //    return View();
        //}
        //Category newCategory = new Category
        //{
        //    Name = category.Name
        //};
        //await _context.Categories.AddAsync(newCategory);
        //await _context.SaveChangesAsync();
        //return RedirectToAction(nameof(Index));
        //}

    }
}