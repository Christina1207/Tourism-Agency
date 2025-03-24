using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Entities
{
    public partial class SEOMetadata
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Required]
        [Column("urlSlug", TypeName = "nvarchar(100)")]
        public string? UrlSlug { get; set; }

        [Required]
        [Column("metaTitle", TypeName = "nvarchar(50)")]
        public string? MetaTile { get; set; }

        [Column("metaDescription", TypeName = "nvarchar(200)")]
        public string? MetaDescription { get; set; }

        [Column("metaKeywords", TypeName = "nvarchar(50)")]
        public string? MetaKeywords { get; set; }

        [Column("postId")]
        [ForeignKey("Post")]
        public int PostId { get; set; }


        // Navigation Properties
        public Post? Post { get; set; }


    }
}
