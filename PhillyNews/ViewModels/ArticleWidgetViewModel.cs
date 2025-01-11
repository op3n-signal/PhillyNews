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
            articleCards = new List<ArticleCard>()
            {
                new ArticleCard()
                {
                    Title = "Sirriani Is Ready?",
                    Preview_Text = "Sirriani is the worst coach in Eagles History and here is why..."
                },
                new ArticleCard()
                {
                    Title = "Is Hurts really what we think?",
                    Preview_Text = "I don't know about you guys or if we were watching the same guy, but this guy stinks!"
                }
            };
        }
    }
}
