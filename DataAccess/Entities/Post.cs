using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataAccess.Entities
{
    public enum PostStatusEnum
    {
        //fixed name from DraPublishedft to Draft
        Draft,
        Pending,
        Published,
        Scheduled,
        Unpublished,
        Archived,
        Deleted
    }
    public partial class Post
    {
        public Post()
        {
            PostTags = new HashSet<PostTag>();
            SEOMetadata = new HashSet<SEOMetadata>();
        }

        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Required]
        [Column("title", TypeName = "nvarchar(50)")]
        public string? Title { get; set; }

        [Required]
        [Column("body", TypeName = "nvarchar(500)")]
        public string? Body { get; set; }

        [Column("image", TypeName = "nvarchar(100)")]
        public string? Image { get; set; }

        [Required]
        [Column("slug", TypeName = "nvarchar(100)")]
        public string? Slug { get; set; }

        [Column("views")]
        public int Views { get; set; }

        [Column("status")]
        [EnumDataType(typeof(PostStatusEnum))]
        public PostStatusEnum Status { get; set; }

        [Column("summary", TypeName = "nvarchar(200)")]
        public string? Summary { get; set; }

        [Column("publishDate")]
        public DateTime PublishDate { get; set; }

        [Column("postTypeId")]
        [ForeignKey("PostType")]
        public int PostTypeId { get; set; }

        [Required]
        [Column("employeeId")]
        [ForeignKey("Employee")]
        public string? EmployeeId { get; set; }

        // Navigation Properties
        public Employee? Employee { get; set; }
        public PostType? PostType { get; set; }
        public ICollection<PostTag> PostTags { get; set; }
        public ICollection<SEOMetadata> SEOMetadata { get; set; }

    }
}
