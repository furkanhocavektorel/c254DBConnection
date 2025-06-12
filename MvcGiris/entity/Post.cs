using System.ComponentModel.DataAnnotations;

namespace MvcGiris.entity
{
    public class Post : BaseEntity
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public string? ImageUrl { get; set; }
        public long User__Id { get; set; }
        public User User { get; set; } // Navigation property

    }
}
