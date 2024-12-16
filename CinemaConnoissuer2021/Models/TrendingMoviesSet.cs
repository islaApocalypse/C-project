using System.Collections.Generic;

namespace CinemaConnoissuer2021.Models {
    public class TrendingMovieSet {
        public int page { get; set; }
        public List<MoviePoster> results { get; set; }
        public int total_pages { get; set; }
        public int total_results { get; set; }
    }
}