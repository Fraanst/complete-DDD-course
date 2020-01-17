
using System;
using Domain.ValueObjects;

namespace Domain.Entities
{
    public class Publishers : User
    {
        public Publishers(Name name,
        Email email,
        Address address,
        Document document,
        DateTime birtDate) : base(
            name,
            email,
            address,
            document,
            birtDate)
        {
            Name = name;
            Email = email;
            Address = address;
            Document = document;
        }
        public string sector { get; set; }

    }
}