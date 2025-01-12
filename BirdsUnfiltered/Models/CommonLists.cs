namespace BirdsUnfiltered.Models
{
    public class CommonLists
    {
        public static List<BlogCard> BlogCards = new List<BlogCard>()
        {
            new BlogCard()
            {
                Slug = "sirrian-is-terrible",
                Title = "Sirriani is the worst coach in Eagles History and here is why",
                Date_Created = new DateTime(2024, 1, 2)
            },
            new BlogCard()
            {
                Slug = "hurts-stinks",
                Title = "I don't know about you guys or if we were watching the same guy, but this guy stinks!",
                Date_Created = new DateTime(2024, 1, 10)
            },
            new BlogCard()
            {
                Slug = "dont-know",
                Title = "I don't know about you guys or if we were watching the same guy, but this guy stinks!",
                Date_Created = new DateTime(2024, 1, 12)
            }
        };


        public static List<Blog> Blogs = new List<Blog>()
        {
            new Blog()
            {
                Slug = "sirrian-is-terrible",
                Body = $@"I shouldn't start this off like this... but I will... so here it goes...<br /><br />
                <i>JALEN HURTS IS A TERRIBLE QUARTERBACK!</i><br /><br />
                I have to preface this by aplogizing to all the Eagles fans everywhere because what I am about to say is not for the faint of heart nor for the blind... 
                Because <i>YOU ARE BLIND</i> if you did not see what I saw! Because what I saw was Saquon Barkley leaving the stadium most games with a torn shirt since this team has been riding his coattails. Thank God for Saquon Barkley! We should be kneeling and kissing his feet for <br /><br />
                2,903 Passing Yards<br />
                18 Touchdowns<br />
                5 Interceptions<br />
                38 Sacks<br />
                68.7 CMP%<br />
                103.7 Rating<br /><br />
                ",
                Title = "I don't know about you guys or if we were watching the same guy, but this guy stinks!",
                Date_Created = new DateTime(2024, 1, 2),
                Media = new List<Media>() 
                {
                    new Media()
                    {
                        Media_Path = "https://static.clubs.nfl.com/image/upload/v1643905779/eagles/wme4xbzoejuoxa5cx80s.png",
                        Media_Type = Enums.MediaType.Image
                    }
                }
            }
        };
    }
}
