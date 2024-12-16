using System.Collections.Generic;

namespace CinemaConnoissuer2021.Models {
    public class TrendingTvSet {
        public int page { get; set; }
        public List<TvPoster> results { get; set; }
        public int total_pages { get; set; }
        public int total_results { get; set; }
    }
}