using System;
using System.Collections.Generic;
using System.Linq;
using Domain.ValueObjects;
namespace Domain.Entities
{
    public class Teachers : User
    {
        IList<string> _classYear;
        public Teachers(
            Name name,
            Email email,
            Address address,
            Document document,
            DateTime birthDate,
            IList<string> school,
            IList<string> classYear) : base(
                name,
                email,
                address,
                document,
                birthDate
            )
        {
            Name = name;
            Email = email;
            Address = address;
            Document = document;
            School = school.ToList();
            ClassYear = classYear.ToList();
        }

        public IReadOnlyCollection<string> School { get; private set; }
        public IReadOnlyCollection<string> ClassYear { get; private set; }
        public IReadOnlyCollection<Discipline> discipline { get; private set; }
    }
}