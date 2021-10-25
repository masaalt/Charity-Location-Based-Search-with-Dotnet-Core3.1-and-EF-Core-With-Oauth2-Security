using System.Collections.Generic;

namespace CharitySpacialSearcher.WebAPI.Models
{
    public class charitiesViewModel
    {
        public class CharitiesViewModel
        {
            public double Latitude { get; set; }
            public double Longitude { get; set; }
            public string Name { get; set; }
            public string Tag { get; set; }
            public double Distance { get; set; }
        }

        public class SearchInputModel
        {
            public double Latitude { get; set; }
            public double Longitude { get; set; }
        }

        public class IndexPageViewModel
        {
            public SearchInputModel SearchInput { get; set; }
            public List<CharitiesViewModel> Charities { get; set; }
        }
    }
}
