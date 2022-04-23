namespace modul8_1302204058
{
    public class Movie
    {
        public string Title { get; set; }
        public string Director { get; set; }
        public string Description { get; set; }
        public Movie(string Title, string Director, string Description)
        {
            this.Title = Title;
            this.Director = Director;
            this.Description = Description;
        }

    }
}
