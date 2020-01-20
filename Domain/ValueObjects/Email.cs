using Flunt.Validations;
using Shared.ValueObjects;

namespace Domain.ValueObjects
{
    public class Email : ValueObject
    {
        public Email(string email)
        {
            Name = email;

            AddNotifications(new Contract()
                .Requires()
                .IsEmail(Name,  "Email", "O Email não é válido!")
            );
        }
        public string Name { get; set; }
    }
}