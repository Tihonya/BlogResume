using System.Collections.Generic;

namespace ResumeBlog.Model.BlogModelClasses
{
    public class UnauthorizedUser
    {

        public int Id { get; set; }

        public string Name { get; set; }

        public string Ip { get; set; }

        public bool IsBlocked { get; set; }

        public List<Comment> Comments { get; set; } = new List<Comment>();
    }
}
