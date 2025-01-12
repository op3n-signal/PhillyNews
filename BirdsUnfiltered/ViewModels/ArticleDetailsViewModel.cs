using PhillyNews.Models;

namespace PhillyNews.ViewModels
{
    public class ArticleDetailsViewModel
    {
        public Article Article { get; set; }

        public void Load(string slug)
        {
            Article = CommonLists.Articles.Find(article => article.Slug == slug);
        }
    }
}
