using BirdsUnfiltered.Models;

namespace BirdsUnfiltered.ViewModels
{
    public class BlogDetailsViewModel
    {
        public Blog Blog { get; set; }

        public void Load(string slug)
        {
            Blog = CommonLists.Blogs.Find(article => article.Slug == slug);
        }
    }
}
