using ResumeBlog.Model.Interfaces;

namespace ResumeBlog.Model.ResumeModelClasses
{
    public class Skill : ICheckChanges
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public int Level { get; set; }

        public SkillSpecification Specification { get; set; }

        public bool IsDirty { get; set; }
    }
}
