namespace BirdsUnfiltered.Models
{
    public class CommonLists
    {
        public static List<BlogCard> BlogCards = new List<BlogCard>()
        {
            new BlogCard()
            {
                Slug = "i-dont-know-about-this-guy",
                Title = "I don't trust Hurts...",
                Date_Created = new DateTime(2024, 1, 12, 15, 0, 0)
            }/*,
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
                Date_Created = new DateTime(2024, 1, 1)
            },
            new BlogCard()
            {
                Slug = "dont-know",
                Title = "I don't know about you guys or if we were watching the same guy, but this guy stinks!",
                Date_Created = new DateTime(2024, 1, 12)
            }*/
        };


        public static List<Blog> Blogs = new List<Blog>()
        {
            /*new Blog()
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
            },*/
            new Blog()
            {
                Slug = "i-dont-know-about-this-guy",
                Title = "I don't trust Hurts...",
                Date_Created = new DateTime(2024, 1, 12, 15, 0, 0),
                Body = $@"
                2,903 Passing Yards<br />
                18 Touchdowns<br />
                5 Interceptions<br />
                38 Sacks<br />
                68.7 CMP%<br />
                103.7 Rating<br /><br />

                Now I am not a Rocket Scientist, as hard as that may be to believe for some of my friends, but clearly we can see that from the numbers above... <i>we are not a passing team... at all!</i><br /><br />
                I know what you might be thinking, ""Hold On, Anthony! We don't need a passing game because we have Saquon!""<br /><br />
                Ha Yeah well, Thank God For that!!! Because there is no way in hell that we will have the record that we have without him.<br /><br />
                And Trust me when I tell you, you don't want to see our passing game.<br /><br />
                Hurts is not a passing quarterback at this time. My reasoning? Well, go back and watch any regular season game this year and tell me he doesn't hold on to the ball longer than it takes for TSA to decide if your 3.1-ounce shampoo is a national security threat.<br /><br />
                He takes too long to pull the trigger. I mean I can't tell you how many times I yelled at the TV, ""THROW THE DAMN BALL!!""<br /><br />
                Now, can he make a play here and there. Sure...<br /><br />
                But there is no way you can rely on him for all 4 quarters. He is suspect to make mistakes and he is not consistent. He can look like a decent quarterback here but sure enough, I know it and you know it... he will poop the bed soon.",
                Media = new List<Media>()
                {
                    new Media()
                    {
                        Media_Path = "https://upload.wikimedia.org/wikipedia/commons/thumb/6/6e/Jalen_Hurts_11-14-22_%28cropped%29.jpg/640px-Jalen_Hurts_11-14-22_%28cropped%29.jpg",
                        Media_Type = Enums.MediaType.Image
                    }
                }
            }
        };
    }
}
