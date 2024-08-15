namespace examWeek7.Models
{
	public class Card
	{

        public int Id { get; set; }

        public int UserId { get; set; }

        public DateTime Date { get; set; }

        public List<Book> Books { get; set; }

        public int __v {  get; set; }

	}
}
