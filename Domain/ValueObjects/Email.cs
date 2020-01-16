namespace Domain.ValueObjects
{
    public class Email
    {
        public Email(string email)
        {
            Name = email;
        }
        public string Name { get; set; }
    }
}