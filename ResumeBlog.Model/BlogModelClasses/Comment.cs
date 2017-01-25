using ResumeBlog.Model.Interfaces;
using System;
using System.Collections.Generic;

namespace ResumeBlog.Model.BlogModelClasses
{
    public class Comment :IModificationHistory
    {
        public Guid Id { get; set; }

        public Guid? ParentId { get; set; }

        public Comment ParentComment { get; set; }

        public string AuthorId { get; set; }

        public UserIdentity Author { get; set; }

        public Guid PostId { get; set; }

        public Post RelatedPost { get; set; }

        public List<Comment> ChildComments { get; set; } = new List<Comment>();

        public int? UnauthorizedUserId { get; set; }

        public UnauthorizedUser UnauthorizedUser { get; set; }

        public bool IsPending { get; set; }

        public bool IsApproved { get; set; }

        public bool IsSpam { get; set; }


        public bool IsAuthorizedUser { get; set; }


        /// <summary>
        ///     Gets the avatar image
        /// </summary>
        public string Avatar { get; set; }


        public string Title { get; set; }

        
        // Comment link
        
        public string RelativeLink { get; set; }
        /// <summary>
        ///     Gets or sets the ip
        /// </summary>
        public string Ip { get; set; }
        /// <summary>
        ///     Comment content
        /// </summary>
        public string Content { get; set; }

        public DateTime DateCreated { get; set;}

        public DateTime DateModified { get; set; }

        public string ModificationAppliedBy { get; set; }

        public bool IsDirty { get; set; }
    }
}
