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
    public class HomeController : Controller
    {
        //Homecontrollerde databaseya elimiz chatmalidi appdbcontextimiz va
        private AppDbContext _context { get; }
        public HomeController(AppDbContext context)
        {
            _context = context;
        }


        public IActionResult Index()
        {
            HomeViewModel home = new HomeViewModel {
                Slides = _context.Slides.ToList(),
                Summary = _context.Summary.FirstOrDefault(),
                Categories = _context.Categories.ToList(),
                //Products = _context.Products.Where(p=>!p.isDeleted).Include(p => p.Images).Include(c => c.Category).OrderByDescending(p => p.ID).Take(8).ToList(),
                Video = _context.Video.FirstOrDefault(),
                VideoSummary = _context.VideoSummary.FirstOrDefault(),
                VideoSummaryList = _context.VideoSummaryList.ToList(),
                ExpertsSummary = _context.ExpertsSummary.FirstOrDefault(),
                ExpertsSummaryList = _context.ExpertsSummaryList.ToList(),
                Blog = _context.Blog.FirstOrDefault(),
                BlogCards = _context.BlogCards.ToList(),
                FloristsSlides = _context.FloristsSlides.ToList(),
                Settings = _context.Settings.ToList(),
            }; 
            return View(home);
        }
    }
}
