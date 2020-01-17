using Domain.ValueObjects;
using Shared.Entities;

namespace Domain.Entities
{
    public class Discipline : Entity
    {
        public Discipline(Name name)
        {
            Name = name;
        }
        public Name Name { get; private set; }
    }
}