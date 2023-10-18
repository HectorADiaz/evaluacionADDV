using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace gameApi.Entities
{
    public class Scope
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int scopeId { get; set; }
        
        [Required]
        [Range(1, 100)]
        public int scopeValue { get; set; }  

    }
}
