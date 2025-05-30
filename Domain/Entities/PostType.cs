using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities
{
    public partial class PostType
    {
        public PostType()
        {
            Posts = new HashSet<Post>();
        }
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Required]
        [Column("title", TypeName = "nvarchar(50)")]
        public string Title { get; set; } = string.Empty;

        [Column("description", TypeName = "nvarchar(200)")]
        public string Description { get; set; } = string.Empty;

        // Navigation Properties
        public ICollection<Post> Posts { get; set; }



    }
}
