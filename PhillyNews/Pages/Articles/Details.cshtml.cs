using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PhillyNews.ViewModels;

namespace PhillyNews.Pages.Articles
{
    public class DetailsModel : PageModel
    {
        public ArticleDetailsViewModel ArticleDetailsViewModel { get; set; }

        [BindProperty(SupportsGet = true)]
        public string Slug { get; set; }

        public DetailsModel()
        {
            ArticleDetailsViewModel = new ArticleDetailsViewModel();
        }

        public void OnGet()
        {
            ArticleDetailsViewModel.Load(Slug);
        }
    }
}
