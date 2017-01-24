using System;

namespace ResumeBlog.Model.ResumeModelClasses
{
    public class WorkExperience
    {
        public int Id { get; set; }

    //    [Localized]
    //    [MaxLength(512)]
        public string CompanyName { get; set; }

        public string Position { get; set; }

        public string Description { get; set; }

        public DateTime From { get; set; }

        public DateTime? To { get; set; }
    }
}
