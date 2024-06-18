using System.ComponentModel.DataAnnotations;

namespace KinoCritic.Data.Entities
{
    public class Show
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(255)]
        public string Title { get; set; }
        public string Creator { get; set; }
        public DateTime ReleaseDate { get; set; }
        public virtual ICollection<Rating> Ratings { get; set; }
    }
}
