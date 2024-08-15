namespace examWeek7.Models
{
    public class Book
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public int Price { get; set; }

        public string Description { get; set; } = string.Empty;

        public string category { get; set; } = string.Empty;

        public string image { get; set; } = string.Empty;

        public Rating Rating { get; set; }

        public void SetRating(int rate, int count)
        {
            Rating = new Rating { Rate = rate, Count = count };
        }
    }
}
