using ResumeBlog.Model.Interfaces;
using System;

namespace ResumeBlog.Model.ResumeModelClasses
{
    public class Project : ICheckChanges
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public string GitHub { get; set; }

        public string DemoUrl { get; set; }

        public DateTime From { get; set; }

        public DateTime? To { get; set; }

        public string DeveloperId { get; set; }

        public bool IsDirty { get; set; }
    }
}
