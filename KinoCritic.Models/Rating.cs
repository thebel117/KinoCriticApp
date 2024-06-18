using System.ComponentModel.DataAnnotations;

namespace KinoCritic.Data.Entities
{
    public class Rating
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int Score { get; set; }
        public string Review { get; set; }
        public int MovieId { get; set; }
        public virtual Movie Movie { get; set; }
        public int ShowId { get; set; }
        public virtual Show Show { get; set; }
    }
}
