using System;
using System.Collections.Generic;

namespace ResumeBlog.Model.BlogModelClasses
{
    public class Category
    {

        public Guid Id { get; set; }



      //  [MaxLength(32)]
        public string Url { get; set; }

        public string Title { get; set; }

   //     public int PRI { get; set; }

        public IEnumerable<Post> Posts { get; set; } = new List<Post>();
    }
}