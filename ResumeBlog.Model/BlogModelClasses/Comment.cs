using System;
using System.Collections.Generic;

namespace ResumeBlog.Model.BlogModelClasses
{
    public class Comment
    {
        public Guid Id { get; set; }

        public Guid? ParentId { get; set; }

        public string AuthorId { get; set; }

        public UserIdentity Author { get; set; }


        public Post RelatedPost { get; set; }
        /// <summary>
        ///     Comment post ID
        /// </summary>
        public Guid PostId { get; set; }
       

        public IEnumerable<Comment> ChildComments { get; set; } = new List<Comment>();


        public bool IsPending { get; set; }
        /// <summary>
        ///     If comment is approved
        /// </summary>
        public bool IsApproved { get; set; }
        /// <summary>
        ///     Whether comment is spam
        /// </summary>
        public bool IsSpam { get; set; }


        public bool IsAuthorizedUser { get; set; }


        /// <summary>
        ///     Gets the avatar image
        /// </summary>
        public string Avatar { get; set; }


        public string Title { get; set; }
        /// <summary>
        ///     Gets or sets the date published
        /// TODO: Implement IModified interface & delete this field
        /// </summary>
        public string DateCreated { get; set; }
        /// <summary>
        /// Comment link
        /// </summary>
        public string RelativeLink { get; set; }
        /// <summary>
        ///     Gets or sets the ip
        /// </summary>
        public string Ip { get; set; }
        /// <summary>
        ///     Comment content
        /// </summary>
        public string Content { get; set; }
    }
}
