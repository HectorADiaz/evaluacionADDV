using Microsoft.EntityFrameworkCore;

namespace gameApi.DTOs
{
    public class StockDto
    {
        public int stockId { get; set; }
        public DefenderDto defender { get; set; }
        public ArticleDto article {  get; set; }
        public int status { get; set; }
      
    }
}
