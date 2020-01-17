
using Domain.Enums;
using Shared.Entities;

namespace Domain.Entities
{
    public class SchoolTest : Entity
    {
        public SchoolTest(string name, ETrailOfSchoolTest trailOfSchoolTest)
        {
            TrailOfSchoolTest = trailOfSchoolTest;
            Name = name;
        }

        public string Name { get; set; }
        public ETrailOfSchoolTest TrailOfSchoolTest { get; set; }
    }
}