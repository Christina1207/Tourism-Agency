using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities
{
    public partial class Car
    {
     
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Required]
        [Column("model", TypeName = "nvarchar(50)")]
        public string? Model { get; set; } 

        [Required]
        [Column("seats")]
        public int Seats { get; set; }

        [Required]
        [Column("color", TypeName = "nvarchar(50)")]
        public string? Color { get; set; }

        [Required]
        [Column("image", TypeName = "nvarchar(50)")]
        public string? Image { get; set; }

        [Required]
        [Column("pph", TypeName = "decimal(16,2)")]
        public decimal Pph { get; set; }

        [Required]
        [Column("ppd", TypeName = "decimal(16,2)")]
        public decimal Ppd { get; set; }

        [Required]
        [Column("mbw", TypeName = "decimal(16,2)")]
        public decimal Mbw { get; set; }

        [Column("categoryId")]
        [ForeignKey("Category")]
        public int CategoryId { get; set; }

        // Navigation Properties
        public Category? Category { get; set; }
        public ICollection<CarBooking>? CarBookings { get; set; }
        public ICollection<TripPlanCar>? TripPlanCars { get; set; }
    }
}
