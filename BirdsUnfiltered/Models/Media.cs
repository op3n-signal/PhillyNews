using BirdsUnfiltered.Models.Enums;

namespace BirdsUnfiltered.Models
{
    public class Media
    {
        public string Media_Path { get; set; }

        public string Alt_Text { get; set; }

        public string Caption { get; set; }

        public MediaType Media_Type { get; set; }
    }
}
