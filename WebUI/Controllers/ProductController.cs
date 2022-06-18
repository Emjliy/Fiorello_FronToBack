using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebUI.DAL;
using WebUI.Models;
using WebUI.ViewModels;

namespace WebUI.Controllers
{
    public class ProductController : Controller
    {
        private AppDbContext _context { get; }
        private IWebHostEnvironment _env { get; }
        public ProductController(AppDbContext context, IWebHostEnvironment env)
        {
            _context = context;
            _env = env;
        }   
        public IActionResult Index()
        {
            //ViewBag.ProductCount = _context.Products.Count();
            List<Product> products = _context.Products.Include(p => p.Images).Include(p => p.Category).Take(9).ToList();
            return View(products);
        }
        //public IActionResult LoadMore()
        //{
        //    List<Product> products =_context.Products.Include(c => c.Category).Skip(8).Take(8).ToList();
        //    return Json(products);
        //}
        public IActionResult LoadMore()
        {
            List<Product> products = _context.Products.Include(c => c.Category).Include(p=>p.Images).Skip(8).Take(8).ToList();
            return PartialView("_ProductPartial", products);
            //return Json(products);
            //return Json(_context.Products.Select(p => new ProductCreateVM
            //{
            //    Id = p.ID,
            //    Name = p.Title,
            //    Price = p.Price,
            //    Category = p.Category.Name

            //}).Take(16).ToList());
        }
    }
}

