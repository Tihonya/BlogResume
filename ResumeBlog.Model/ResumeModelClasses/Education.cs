using System;
using System.Collections.Generic;

namespace ResumeBlog.Model.ResumeModelClasses
{
    public class Education
    {
        public int Id { get; set; }
//        [MaxLength(512)]
        public string School { get; set; }

        public string Profession { get; set; }

        public IEnumerable<KeyPoint> KeyPoints { get; set; } = new List<KeyPoint>();

        public DateTime From { get; set; }

        public DateTime? To { get; set; }
    }
}
