using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FinShark.Models
{
    public class Comment
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(500)]
        public string Content { get; set; } = string.Empty;

        [Required]
        public DateTime CreatedAt { get; set; }

        [ForeignKey("Stock")]
        public int? StockId { get; set; }

        public Stock? Stock { get; set; }

        // Constructor
        
    }
}