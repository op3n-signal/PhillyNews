using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using BirdsUnfiltered.ViewModels;

namespace BirdsUnfiltered.Pages.Articles
{
    public class DetailsModel : PageModel
    {
        public BlogDetailsViewModel ArticleDetailsViewModel { get; set; }

        [BindProperty(SupportsGet = true)]
        public string Slug { get; set; }

        public DetailsModel()
        {
            ArticleDetailsViewModel = new BlogDetailsViewModel();
        }

        public void OnGet()
        {
            ArticleDetailsViewModel.Load(Slug);
        }
    }
}
