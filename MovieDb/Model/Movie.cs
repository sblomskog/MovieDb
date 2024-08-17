namespace MovieDb.Model
{
    public class Movie
    {
        private int _id;

        public int Id
        {
            get => _id;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(value), "Id must be greater than or equal to 0.");
                }

                _id = value;
            }
        }
        public string? Title { get; set; }
        public string? Genre { get; set; }
        public int? Year { get; set; }
        public string? Director { get; set; }
        public string? Rating { get; set; }
        public bool Watched { get; set; }
        public bool Owned { get; set; }
    }
}
