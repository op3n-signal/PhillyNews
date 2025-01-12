namespace BirdsUnfiltered.Models
{
    public class Blog
    {
        public string Slug { get; set; }

        public string Title { get; set; }   

        public string Body { get; set; }

        //Media will be inserted where the place holders are in the body
        public List<Media> Media {  get; set; } 

        public DateTime Date_Created { get; set; }
    }
}
