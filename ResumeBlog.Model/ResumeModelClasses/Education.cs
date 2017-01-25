using ResumeBlog.Model.Interfaces;
using System;
using System.Collections.Generic;

namespace ResumeBlog.Model.ResumeModelClasses
{
    public class Education : ICheckChanges
    {
        public int Id { get; set; }

        public string School { get; set; }

        public string Specialization { get; set; }

        public List<KeyPoint> KeyPoints { get; set; } = new List<KeyPoint>();

        public DateTime From { get; set; }

        public DateTime? To { get; set; }

        public bool IsDirty { get; set; }
    }
}
