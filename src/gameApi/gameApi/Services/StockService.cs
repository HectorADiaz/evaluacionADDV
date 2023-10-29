using gameApi.DTOs;
using gameApi.Entities;
using gameApi.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace gameApi.Services
{
    public class StockService : IStockService
    {
        private readonly ApplicationDbContext _context;

        public StockService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<StockDto>> GetStock()
        {
            List<StockDto> result = await _context.stocks.Select(
                stock => new StockDto
                {
                    stockId = stock.stockId,
                    defender = new DefenderDto{
                        defenderId = stock.Defender.defenderId,
                        defenderName = stock.Defender.defenderName,
                        balance = stock.Defender.balance,
                        shot = stock.Defender.shot
                    },
                    article = new ArticleDto{
                        articleId = stock.Article.articleId,
                        articleName = stock.Article.articleName,
                        articlePrice = stock.Article.articlePrice,
                        scopeValue = stock.Article.scopeValue
                    },
                    status = stock.status
                }).ToListAsync();

            return result;
        }
    }
}

