using Shared.ValueObjects;

namespace Domain.ValueObjects
{
    public class Document : ValueObject
    {
        public Document(string number){
            Number = number;
        }

        public string Number { get; set; }
    }
}