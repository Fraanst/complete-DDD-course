using System.Collections.Generic;

namespace Domain.Entities
{
    public class Content
    {
        public Content(string name, string description, List<string> documents)
        {
            Name = name;
            Description = description;
            Documents = documents;
        }

        public string Name { get; private set; }
        public string Description { get; private set; }
        public IReadOnlyCollection<string> Documents { get; private set; }
    }
}