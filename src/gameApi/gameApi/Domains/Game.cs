using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace gameApi.Entities
{
    public class Game
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int gameId { get; set; }
        
        [Required]
        [Range(1, 100)]
        public int cityPoints { get; set; }

        [Required]
        [Range(10, 100)]
        [ForeignKey("Manticora")]
        public int manticoraId { get; set; }

        public Manticora Manticora { get; set; }
      
    }
}
