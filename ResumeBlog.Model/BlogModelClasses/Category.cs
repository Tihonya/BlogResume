using System;
using System.Collections.Generic;

namespace ResumeBlog.Model.BlogModelClasses
{
    public class Category
    {

        public Guid Id { get; set; }

        //  [MaxLength(32)] this field awaits usege on
        //practice for clarify EntityConfiguration
        public string Url { get; set; }

        public string Title { get; set; }

        //For Admin Only and with "tambourine"
        //(to avoid cascade deleting Posts)
        public bool IsDeleted { get; set; }

   //     public int PRI { get; set; } ???

        public List<Post> Posts { get; set; } = new List<Post>();
    }
}