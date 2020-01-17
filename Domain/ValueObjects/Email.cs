using Shared.ValueObjects;

namespace Domain.ValueObjects
{
    public class Email : ValueObject
    {
        public Email(string email)
        {
            Name = email;
        }
        public string Name { get; set; }
    }
}