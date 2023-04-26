namespace modul9_1302210025.Controllers
{
    public class Movie
    {
        public int id;
        private string title, director, description;
        private List<string> Stars;
        public Movie() { }
        public Movie(int id,string title, string director, string description, List<string> stars)
        {
            this.id = id;
            this.title = title;
            this.director = director;
            this.description = description;
            Stars = stars;
        }
    }
}
