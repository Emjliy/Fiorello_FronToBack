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
            return View();
        }
        public IActionResult LoadMore(int skip=8)
        {
            List<Product> products = _context.Products.Where(p => !p.isDeleted).Include(p => p.Images).Include( p=> p.Category).OrderByDescending(p => p.ID).Skip(skip).Take(8).ToList();
            return PartialView("_ProductPartial", products);
            //return Json(products);
        }
    }
}   

