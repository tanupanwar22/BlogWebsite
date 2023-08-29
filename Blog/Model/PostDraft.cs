using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Blog.Model
{
    [Table("PostDraft")]
    public class PostDraft
    {
        [Required, Key]
        public Guid PostId { get; set; }

        [Column(TypeName = "VARCHAR(100)"), Required]
        public string Title { get; set; }

        [Column(TypeName = "VARCHAR(100)")]
        public string AuthorId { get; set; }

        [Column(TypeName = "VARCHAR(100)")]
        public string AuthorName { get; set; }

        [Column(TypeName = "nVARCHAR(max)"), Required]
        public string Content { get; set; }

        [Column(TypeName = "NVARCHAR(256)")]
        public string Status { get; set; }

        [Column(TypeName = "datetime")]
        public DateTime Creation_Date { get; set; }

        [Column(TypeName = "datetime")]
        public DateTime Update_Date { get; set; }

        [Column(TypeName = "datetime")]
        public DateTime Published_Date { get; set; }
    }
}