using Shared.ValueObjects;

namespace Domain.ValueObjects
{
    public class Address : ValueObject
    {
        public Address(string street, string number, string neighborhood, string city, string state, string country)
        {
            Country = country;
            Number = number;
            Neighborhood = neighborhood;
            City = city;
            Street = street;
            State = state;
            Country = country;
        }
        public string Country { get; set; }
        public string State { get; set; }
        public string City { get; set; }
        public string Number { get; set; }
        public string Street { get; set; }
        public string Neighborhood { get; set; }
    }
}