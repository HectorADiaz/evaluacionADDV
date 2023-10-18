using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace gameApi.Entities
{
    public class Attack
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int attackId { get; set; }

        [ForeignKey("Game")]
        [Required]
        [Range(10, 100)]
        public int gameId { get; set; }

        [Required]
        [ForeignKey("Defender")]
        [Range(10, 100)]
        public int defenderId { get; set; }



    }
}
