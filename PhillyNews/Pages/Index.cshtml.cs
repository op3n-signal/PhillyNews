using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PhillyNews.ViewModels;

namespace PhillyNews.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        public ArticleWidgetViewModel ArticleWidgetViewModel { get; set; }

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
            ArticleWidgetViewModel = new ArticleWidgetViewModel();
        }

        public void OnGet()
        {
            ArticleWidgetViewModel.Load();
        }
    }
}
