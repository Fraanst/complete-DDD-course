using System.Collections.Generic;

namespace Domain.Entities
{
    public class Reinforcement
    {
        public Reinforcement(string name, string description, List<string> image)
        {
            Name = name;
            Description = description;
            Image = image;
        }

        public string Name { get; private set; }
        public string Description { get; private set; }
        public IReadOnlyCollection<string> Image { get; private set; }
    }
}