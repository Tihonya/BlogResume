namespace ResumeBlog.Model.ResumeModelClasses
{
    public class KeyPoint
    {
        public int Id { get; set; }

        public string About { get; set; }

        public int EducationId { get; set; }

        public Education Education { get; set; }
    }
}