using System;
using System.Collections.Generic;

namespace ResumeBlog.Model.ResumeModelClasses
{
    public class DeveloperProfile
    {

        public int Id { get; set; }

        public string UserId { get; set; }

        public UserIdentity Developer { get; set; }

        public DateTime Birthday { get; set; }

        public string ContactPhone { get; set; }

        public string Email { get; set; }

        public string SelfIntroduce { get; set; } 

        public string Position { get; set; } 

        public string GitHubUrl { get; set; }

        public string BlogUrl { get; set; }

        public string LinkedInUrl { get; set; }

        public string AdditionalInformation  { get; set; }

        public IEnumerable<Skill> Skills { get; set; } = new List<Skill>();

        public IEnumerable<Project> Projects { get; set; } = new List<Project>();

        public IEnumerable<Education> Educations { get; set; } = new List<Education>();

        public IEnumerable<WorkExperience> WorkExperiences { get; set; } = new List<WorkExperience>();

    }
}
