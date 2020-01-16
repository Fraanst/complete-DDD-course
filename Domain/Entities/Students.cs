using System.Collections.Generic;
using Domain.ValueObjects;

namespace Domain.Entities
{
    public class Students : Entity
    {        
        public Students(Name name, Email email, Address address, Document document)
        {
            Name = name;
            Email = email;
            Address = address;
            Document = document;
        }
        public Name Name { get; private set; }
        public Email Email { get; private set; }
        public Address Address { get; private set; }
        public Document Document { get; private set; }

        public List<discipline> discipline { get; private set; }
    }
}