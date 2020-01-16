using System.Collections.Generic;
using Domain.ValueObjects;
using Shared.Entities;

namespace Domain.Entities
{
    public class Students : Entity
    {
        private IList<Discipline> _discipline;
        public Students(Name name, Email email, Address address, Document document)
        {
            Name = name;
            Email = email;
            Address = address;
            Document = document;
            _discipline = new List<Discipline>();
        }
        public Name Name { get; set; }
        public Email Email { get; set; }
        public Address Address { get; set; }
        public Document Document { get; set; }

        public IReadOnlyCollection<Discipline> discipline { get; set; }
    }
}