using ResumeBlog.Model.Interfaces;
using System;

namespace ResumeBlog.Model.ResumeModelClasses
{
    public class WorkExperience : ICheckChanges
    {
        public int Id { get; set; }

        public string CompanyName { get; set; }

        public string Position { get; set; }

        public string Description { get; set; }

        public DateTime From { get; set; }

        public DateTime? To { get; set; }

        public bool IsDirty { get; set; }
    }
}
