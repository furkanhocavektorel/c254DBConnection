﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcGiris.entity
{
    [Table("Posts")]
    public class Post : BaseEntity
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public string? ImageUrl { get; set; }

        [ForeignKey("User")]
        public long User__Id{ get; set; }

        public User User { get; set; } // Navigation property


    }
}
