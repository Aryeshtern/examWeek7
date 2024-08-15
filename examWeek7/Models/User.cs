using System.Reflection.Metadata.Ecma335;

namespace examWeek7.Models
{
    public class User
    {
        public int Id { get; set; }

        public Address Address { get; set; }

        public void SetAddress(string lat, string longg, string city, string street, int number, string zipcode)
        {
            Address = new Address { City = city, Street = street, Number = number, Zipcode = zipcode, Geolocation = new Geolocation { Lat = lat, Long = longg } };
         }

        public string Email { get; set; }

        public string Username { get; set; }

        public string Password { get; set; } 

        public Name Name { get ; set ; }

        public void SetName(string firstname, string lastname)
        {
            Name = new Name { FirstName = firstname, LastName = lastname };
        }

        public string Phone { get; set; }

        public int __v { get; set; }



	
	}
}
