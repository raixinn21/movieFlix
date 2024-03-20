namespace movieFlix.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Genre { get; set; }
        public string Director { get; set; }
        public string Producer { get; set; }
        public string Actor { get; set; }
        public string Actress { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string Price { get; set; }
    }
}
