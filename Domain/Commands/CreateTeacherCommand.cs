using System.Collections.Generic;
using Domain.Entities;
using Domain.Enums;
using Flunt.Validations;

namespace Domain.Commands
{
    public class CreateTeacherCommand : UserCommand
    {
        public List<string> School { get; private set; }
        public List<EClassYear> ClassYear { get; private set; }
        public List<Discipline> discipline { get; private set; }

        public void ValidateCreateTeacher()
        {
            AddNotifications(new Contract()
            .Requires()
            //.HasMinLen(School, 3, "School", "O Nome da Escola deve conter pelo menos 3 caracteres")
            //.IsNotNullOrEmpty(ClassYear, "ClassYear", "O Número da turma deve ser preenchido")
            //.IsNotNullOrEmpty(Discipline, "Discipline", "Pelo menos uma disciplina deve ser informada")
            );
        }
    }
}