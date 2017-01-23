using System;

namespace ResumeBlog.Model.ResumeModelClasses
{
    public class Project
    {
        public int Id { get; set; }

   //     [MaxLength(256)]
        public string Title { get; set; }

  //      [MaxLength(1024)]
        public string Description { get; set; }

        public string GitHub { get; set; }


        public string DemoUrl { get; set; }

        public DateTime From { get; set; }

        public DateTime? To { get; set; }


    }
}
