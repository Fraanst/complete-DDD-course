using System;
using Flunt.Validations;
using Shared.ValueObjects;

namespace Domain.ValueObjects
{
    public class Address : ValueObject
    {
        public Address(string street, string zipCode,string number, string neighborhood, string city, string state, string country)
        {
            Country = country;
            Number = number;
            Neighborhood = neighborhood;
            City = city;
            Street = street;
            State = state;
            ZipCode = zipCode;

            AddNotifications(new Contract()
                .Requires()
                .HasMinLen(Country, 3, "Address.Country", "País deve conter pelo menos 3 caracteres")
                .HasMinLen(Street, 3, "Address.Street", "Cidade deve conter pelo menos 3 caracteres")
                .HasMinLen(City, 3, "Address.City", "Cidade deve conter pelo menos 3 caracteres")
                .HasMinLen(Neighborhood, 3, "Address.LastName", "Bairro deve conter pelo menos 3 caracteres")
                .IsNotNullOrEmpty(Number, "Address.Number", "Número deve ser preenchido")
                .IsNotNullOrEmpty(State, "Address.State", "Estado deve ser preenchido")
                .IsNotNullOrEmpty(ZipCode, "Address.ZipCode", "Código Postal deve ser preenchido")
                );
        }
        public string Country { get; set; }
        public string State { get; set; }
        public string City { get; set; }
        public string Number { get; set; }
        public string Street { get; set; }
        public string Neighborhood { get; set; }
        public string ZipCode { get; set; }
    }
}