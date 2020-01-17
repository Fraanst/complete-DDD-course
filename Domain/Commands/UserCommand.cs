using System;
using Domain.ValueObjects;
using Shared.Commands;

using Flunt.Notifications;
using Flunt.Validations;

namespace Domain.Commands
{
    public abstract class UserCommand : Notifiable, ICommand
    {
        public Name Name { get; set; }
        public Email Email { get; set; }
        public Document Document { get; set; }
        public Address Address { get; set; }
        public DateTime BirthDate { get; set; }

        public void Validate()
        {
            AddNotications(new Contract()
                .Requires()
                .HasMinLen(Name, ))
        }
    }
}