using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using BirdsUnfiltered.ViewModels;

namespace BirdsUnfiltered.Pages.Blogs
{
    public class DetailsModel : PageModel
    {
        public BlogDetailsViewModel BlogDetailsViewModel { get; set; }

        [BindProperty(SupportsGet = true)]
        public string Slug { get; set; }

        public DetailsModel()
        {
            BlogDetailsViewModel = new BlogDetailsViewModel();
        }

        public void OnGet()
        {
            BlogDetailsViewModel.Load(Slug);
        }
    }
}
