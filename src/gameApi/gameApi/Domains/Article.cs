using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace gameApi.Entities
{
    public class Article
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int articleId { get; set; }

        [Required]
        [StringLength(75)]
        public string articleName { get; set; }
        
        [Required]
        [Range(1, 100)]
        public int articlePrice { get; set; }

        [Required]
        [Range(1, 100)]
        [ForeignKey("Scope")]
        public int scopeId { get; set; }
        public Scope Scope { get; set; }

    }
}
