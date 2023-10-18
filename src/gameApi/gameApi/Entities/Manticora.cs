using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace gameApi.Entities
{
    public class Manticora
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int manticoraId { get; set; }

        [Required]
        [Range(1, 100)]
        public int manticoraPoints { get; set; }

        [Required]
        [Range(1, 100)]
        public int manticoraPosition { get; set; }

    }
}
