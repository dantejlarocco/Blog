using System;
using System.ComponentModel.DataAnnotations;

namespace Blog.Models
{
    public class BlogPost
    {
        public int Id { get; set; }

        [Required, StringLength(100)]
        public string Title { get; set; } = string.Empty;

        [Required, StringLength(5000)]
        public string Content { get; set; } = string.Empty;

        [DataType(DataType.Date)]
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }
}
