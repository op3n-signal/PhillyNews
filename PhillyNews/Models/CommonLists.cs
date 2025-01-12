namespace PhillyNews.Models
{
    public class CommonLists
    {
        public static List<ArticleCard> ArticleCards = new List<ArticleCard>()
        {
            /*new ArticleCard()
            {
                Slug = "sirrian-is-terrible",
                Title = "Sirriani is the worst coach in Eagles History and here is why...",
            },
            new ArticleCard()
            {
                Slug = "hurts-stinks",
                Title = "I don't know about you guys or if we were watching the same guy, but this guy stinks!"
            }*/
        };


        public static List<Article> Articles = new List<Article>()
        {
            new Article()
            {
                Slug = "sirrian-is-terrible",
                Body = "body text",
                Title = "Sirriani is the worst coach in Eagles History and here is why...",
                Date_Created = new DateTime(2024, 1, 2)
            }
        };
    }
}
