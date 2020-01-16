using Domain.ValueObjects;

namespace Domain.Entities
{
    public class discipline : Entity
    {
        public discipline(Name name)
        {
            Name = name;
        }
        public Name Name { get; private set; }
    }
}