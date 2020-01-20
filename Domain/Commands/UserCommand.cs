using System;
using Domain.ValueObjects;
using Shared.Commands;

using Flunt.Notifications;
using Flunt.Validations;

namespace Domain.Commands
{
    public abstract class UserCommand : Notifiable, ICommand
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Document { get; set; }
        public string Street { get; set; }
        public string Number { get; set; }
        public string Neighborhood { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public string ZipCode { get; set; }
        public DateTime BirthDate { get; set; }

        public void Validate()
        {
            AddNotifications(new Contract()
                .Requires()
                .HasMinLen(FirstName, 3, "Name.FirstName", "Nome deve conter pelo menos 3 caracteres")
                .HasMaxLen(FirstName, 40, "Name.FirstName", "Nome deve conter até 40 caracteres")
                .HasMinLen(LastName, 3, "Name.LastName", "Sobrenome deve conter pelo menos 3 caracteres")
                .HasMaxLen(LastName, 40, "Name.LastName", "Sobrenome deve conter até 40 caracteres")
                .IsEmail(Email, "Email", "O Email não é válido!")
                .HasMinLen(Country, 3, "Address.Country", "País deve conter pelo menos 3 caracteres")
                .HasMinLen(Street, 3, "Address.Street", "Cidade deve conter pelo menos 3 caracteres")
                .HasMinLen(City, 3, "Address.City", "Cidade deve conter pelo menos 3 caracteres")
                .HasMinLen(Neighborhood, 3, "Address.LastName", "Bairro deve conter pelo menos 3 caracteres")
                .IsNotEmpty(Guid.Empty, "Address.Number", "Nome deve conter até 40 caracteres")
                .IsNotEmpty(Guid.Empty, "Address.State", "Nome deve conter até 40 caracteres")
            );
        }
    }
}