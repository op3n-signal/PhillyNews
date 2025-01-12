using PhillyNews.Models;

namespace PhillyNews.ViewModels
{
    public class ArticleWidgetViewModel
    {
        public List<ArticleCard> articleCards;

        public ArticleWidgetViewModel()
        {

        }

        public void Load()
        {
            articleCards = CommonLists.ArticleCards;
        }
    }
}
