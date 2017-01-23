using System;

namespace ResumeBlog.Model.BlogModelClasses
{
    public class PostTag
    {
        public int Id { get; set; }

  //      [ForeignKey("Post")]
        public Guid PostId { get; set; }

        public Post Post { get; set; }

   //     [MaxLength(64)]
        public string Tag { get; set; }
    }
}