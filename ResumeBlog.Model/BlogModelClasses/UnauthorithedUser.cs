using System.Collections.Generic;

namespace ResumeBlog.Model.BlogModelClasses
{
    public class UnauthorizedUser
    {

        public int Id { get; set; }

        public string Name { get; set; }

        public string Ip { get; set; }

        public IEnumerable<Comment> Comments { get; set; } = new List<Comment>();
    }
}
