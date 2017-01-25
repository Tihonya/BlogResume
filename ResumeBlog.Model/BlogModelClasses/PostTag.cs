﻿using System;

namespace ResumeBlog.Model.BlogModelClasses
{
    public class PostTag
    {
        public int Id { get; set; }

        public Guid PostId { get; set; }

        public Post Post { get; set; }

        public string Tag { get; set; }
    }
}