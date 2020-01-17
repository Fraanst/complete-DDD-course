using System;
using Domain.ValueObjects;
using Shared.Entities;

namespace Domain.Entities
{
    public abstract class User : Entity
    {
        public User(Name name, Email email, Address address, Document document, DateTime birthDate)
        {
            Name = name;
            Email = email;
            Address = address;
            Document = document;
            BirthDate= birthDate;
        }
        public Name Name { get; set; }
        public Email Email { get; set; }
        public Document Document { get; set; }
        public Address Address { get; set; }
        public DateTime BirthDate { get; set; }
    }
}