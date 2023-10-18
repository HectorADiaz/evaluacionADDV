using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Transactions;

namespace gameApi.Entities
{
    public class Stock
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int stockId { get; set; }

        
        [Required]
        [Range(1, 100)]
        [ForeignKey("Defender")]
        public int defenderId { get; set; }

        [Required]
        [Range(1, 100)]
        [ForeignKey("Article")]
        public int articleId { get; set; }

        public int status { get; set; }


    }
}
