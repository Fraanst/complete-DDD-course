using System;
using System.Collections.Generic;
using Domain.ValueObjects;

namespace Domain.Entities
{
    public class Students : User
    {
        private IList<Discipline> _discipline;
        public Students(
            Name name,
            Email email,
            Address address,
            Document document,
            DateTime birthDate,
            string school,
            string classYear) : base(
            name,
            email,
            address,
            document,
            birthDate)
        {
            Name = name;
            Email = email;
            Address = address;
            Document = document;
            School = school;
            ClassYear = classYear;
        }
        public string School { get; set; }
        public string ClassYear { get; set; }
        public IReadOnlyCollection<Discipline> Discipline { get; private set; }
    }
}