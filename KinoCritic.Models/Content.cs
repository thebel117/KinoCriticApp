using System.ComponentModel.DataAnnotations;

namespace KinoCritic.Data.Entities
{
    public abstract class Content
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(255)]
        public string? Title { get; set; }

        public string? Description { get; set; }
    }
}
