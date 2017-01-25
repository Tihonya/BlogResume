using ResumeBlog.Model.Interfaces;
using System;
using System.Collections.Generic;

namespace ResumeBlog.Model.BlogModelClasses
{
    public class Post : IModificationHistory  // : IConvertible<PostViewModel> 
    {


        public Guid Id { get; set; }

        public UserIdentity Author { get; set; }

        public string AuthorId { get; set; }

        public string Url { get; set; }

        public string Title { get; set; }

        public string Summary { get; set; }

        public string Content { get; set; }
        
        public bool IsPublished { get; set; }

        public Guid CategoryId { get; set; }

        public Category Category { get; set; }

        //Full delete only for admin
        public bool IsDeleted { get; set; }

        public  List<PostTag> Tags { get; set; } = new List<PostTag>();

        public List<Comment> Comments { get; set; } = new List<Comment>();

        public DateTime DateModified { get; set; }

        public DateTime DateCreated { get; set; }

        public string ModificationAppliedBy { get; set; }

        public bool IsDirty { get; set; }


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
