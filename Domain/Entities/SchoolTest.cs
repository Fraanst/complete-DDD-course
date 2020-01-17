using System.Collections.Generic;
using Shared.Entities;

namespace Domain.Entities
{
    public class SchoolTest : Entity
    {
        private IList<Exercise> _exercise;
        private IList<Test> _test;
        public SchoolTest(string name, Content content, Reinforcement reinforcement)
        {
            Name = name;
            Reinforcement = reinforcement;
            Content = content;
            _test = new List<Test>();
            _exercise = new List<Exercise>();
        }

        public string Name { get; set; }
        public IReadOnlyCollection<Exercise> Exercise { get; set; }
        public Reinforcement Reinforcement { get; set; }
        public Content Content { get; set; }
        public IReadOnlyCollection<Test> Test { get; set; }
        public KnowMore KnowMore { get; set; }
    }
}