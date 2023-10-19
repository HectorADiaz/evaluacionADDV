using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace gameApi.Entities
{
    public class Defender
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int defenderId { get; set; }

        [StringLength(50)]
        public string defenderName { get; set; }

        [Required]
        [Range(1, 100)]
        public int balance { get; set; }

        [Required]
        [Range(1, 100)]
        public int shot { get; set; }
    }
}
