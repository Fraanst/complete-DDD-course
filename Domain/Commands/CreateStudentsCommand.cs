using System.Collections.Generic;
using Domain.Entities;
using Flunt.Validations;

namespace Domain.Commands
{
    public class CreateStudentsCommand : UserCommand
    {
        public string School { get; set; }
        public string ClassYear { get; set; }
        public List<Discipline> Discipline { get; set; }

        public void ValidateCreateStudent()
        {
            AddNotifications(new Contract()
                .Requires()
                .HasMinLen(School, 3, "School", "O Nome da Escola deve conter pelo menos 3 caracteres")
                .IsNotNullOrEmpty(ClassYear, "ClassYear", "O Número da turma deve ser preenchido")
                //.IsNotNullOrEmpty(Discipline, "Discipline", "Pelo menos uma disciplina deve ser informada")
            );
        }
    }
}