using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebUI.DAL;
using WebUI.Models;

namespace WebUI.ViewComponents
{
    public class ProductsViewComponent:ViewComponent
    {
        private AppDbContext _context { get; }
        public ProductsViewComponent(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            List<Product> products = _context.Products.Where(p => !p.isDeleted).Include(p => p.Images).Include(c => c.Category).OrderByDescending(p => p.ID).Take(8).ToList();
            return View(await Task.FromResult(products));
        }
    }
}
