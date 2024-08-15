namespace examWeek7.Models
{
	public class Address
	{

        public string City { get; set; }

        public string Street { get; set; }

        public int Number { get; set; }

        public string Zipcode { get; set; }

        public Geolocation Geolocation { get; set; }

        public void SetGeolocation(string lat, string longg)
        {
			Geolocation = new Geolocation {  Lat = lat, Long = longg };

		}

	}
}
