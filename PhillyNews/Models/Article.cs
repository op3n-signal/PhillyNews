namespace PhillyNews.Models
{
    public class Article
    {
        public string Slug { get; set; }

        public string Title { get; set; }   

        public string Body { get; set; }

        public DateTime Date_Created { get; set; }
    }
}
