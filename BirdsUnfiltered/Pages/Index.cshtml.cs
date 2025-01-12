using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using BirdsUnfiltered.ViewModels;

namespace BirdsUnfiltered.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        public BlogWidgetViewModel BlogWidgetViewModel { get; set; }

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
            BlogWidgetViewModel = new BlogWidgetViewModel();
        }

        public void OnGet()
        {
            BlogWidgetViewModel.Load();
        }
    }
}
