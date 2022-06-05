using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebUI.Models;

namespace WebUI.DAL
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        public DbSet<Slider> Slides { get; set; }
        public DbSet<Summary> Summary { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductImage> ProductImages { get; set; }
        public DbSet<Video> Video { get; set; }
        public DbSet<VideoSummary> VideoSummary { get; set; }
        public DbSet<VideoSummaryList> VideoSummaryList { get; set; }
        public DbSet<ExpertsSummary> ExpertsSummary { get; set; }
        public DbSet<ExpertsSummaryList> ExpertsSummaryList { get; set; }
        public DbSet<Blog> Blog { get; set; }
        public DbSet<BlogCard> BlogCards { get; set; }
        public DbSet<FloristsSlider> FloristsSlides { get; set; }



    }
}
