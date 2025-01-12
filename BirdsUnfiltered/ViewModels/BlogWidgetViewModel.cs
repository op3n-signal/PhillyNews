using BirdsUnfiltered.Models;

namespace BirdsUnfiltered.ViewModels
{
    public class BlogWidgetViewModel
    {
        public List<BlogCard> blogCards;

        public BlogWidgetViewModel()
        {

        }

        public void Load()
        {
            blogCards = CommonLists.BlogCards;
        }
    }
}
