using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RazorPagesMovie.Models
{
    public class Books
    {
        public int ID { get; set; } 

        [StringLength(60, MinimumLength = 3), Required]
        public string Title { get; set; } = string.Empty;

        [StringLength(60, MinimumLength = 3), Required]
        public string Author { get; set; } = string.Empty;

        [Range(1, 100), DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Price { get; set; }

        public bool IsReccomended { get; set; }
        public int Pages { get; set; }
    }
}
