using Domain.ValueObjects;

namespace Domain.Entities
{
    public class Students
    {        
        public Students(Name name, Email email, Address address, Document document)
        {
            Name = name;
            Email = email;
            Address = address;
            Document = document;
        }
        public Name Name { get; set; }
        public Email Email { get; set; }
        public Address Address { get; set; }
        public Document Document { get; set; }
    }
}