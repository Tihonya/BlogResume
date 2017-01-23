using System;
using System.Collections.Generic;

namespace ResumeBlog.Model.BlogModelClasses
{
    public class Post // : IConvertible<PostViewModel>
    {

        public Post()
        {
            Tags=new List<PostTag>();
            Comments=new List<Comment>();

        }
        public Guid Id { get; set; }

        public UserIdentity Author { get; set; }

        public string AuthorId { get; set; }

       // [MaxLength(256)]
        public string Url { get; set; }

        public string Title { get; set; }

        public string Summary { get; set; }

        public string Content { get; set; }

        public DateTime Time { get; set; }

        public bool IsPublished { get; set; }

      //  [ForeignKey("Category")]
        public Guid CategoryId { get; set; }

        public Category Category { get; set; }

        public  IEnumerable<PostTag> Tags { get; set; }

        public IEnumerable<Comment> Comments { get; set; }


        




        //PostViewModel IConvertible<PostViewModel>.ToType()
        //{
        //    return new PostViewModel
        //    {
        //        Id = Id,
        //        Summary = Summary,
        //        Category = Category,
        //        CatalogId = CatalogId,
        //        Tags = Tags.ToList(),
        //        Time = Time,
        //        Title = Title,
        //        Url = Url
        //    };
        //}
    }
}
