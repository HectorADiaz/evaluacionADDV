using gameApi.DTOs;

namespace gameApi.Interfaces
{
    public interface IStockService
    {
         Task<List<StockDto>> GetStock();
    }
}
