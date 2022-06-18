using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebUI.Models;

namespace WebUI.ViewModels
{
    public class HomeViewModel
    {
        public List<Slider> Slides { get; set; }
        public Summary Summary { get; set; }
        public List<Category> Categories { get; set; }
        public List<Product> Products { get; set; }
        public Video Video { get; set; }
        public VideoSummary VideoSummary { get; set; }
        public List<VideoSummaryList> VideoSummaryList { get; set; }
        public ExpertsSummary ExpertsSummary { get; set; }
        public List<ExpertsSummaryList> ExpertsSummaryList { get; set; }
        public Blog Blog { get; set; }
        public List<BlogCard> BlogCards { get; set; }
        public List<FloristsSlider> FloristsSlides { get; set; }

    }
}
