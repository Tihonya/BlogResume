namespace ResumeBlog.Model.ResumeModelClasses
{
    public class Skill
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public int Level { get; set; }

        public SkillSpecification Specification { get; set; }
    }
}
