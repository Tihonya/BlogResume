using System;

namespace ResumeBlog.Model.ResumeModelClasses
{
    public class Education
    {
        public long Id { get; set; }
//        [MaxLength(512)]
        public string School { get; set; }

        public string Profession { get; set; }

        public string About { get; set; }

        public DateTime From { get; set; }

        public DateTime? To { get; set; }
    }
}
