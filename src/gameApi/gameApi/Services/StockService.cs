using gameApi.DTOs;
using gameApi.Entities;
using Microsoft.EntityFrameworkCore;

namespace gameApi.Services
{
    public class StockService
    {
        public static async Task<List<StockDto>> GetStock(ApplicationDbContext context)
        {
            //var stock = await context.stocks.Select(x => new StockDto
            //{
            //    stockId = x.stockId,
            //    defender = new DefenderDto { 
            //        defenderId = x.Defender.defenderId,
            //        defenderName = x.Defender.defenderName,
            //        defenderBalance = x.Defender.balance,
            //        defenderShot = x.Defender.shot
            //    },
            //    article = new ArticleDto { 
            //        articleId = x.Article.articleId,
            //        articleName = x.Article.articleName,
            //        articlePrice = x.Article.articlePrice
            //      //  scopeValue = (y => new ScopeDto { scopeValue = y.scope.value})
            //    },
            //    status = x.status
            //}).ToListAsync();
            //var stock = await context.stocks.Select(x => new StockDto
            //{
            //    stockId = x.stockId,

            //    status = x.status
            //}).ToListAsync();
            //var groupedStocks = await context.stocks
            //.GroupBy(s => s.defenderId) // Agrupa por defenderId
            //.Select(group => new StockDto
            //{
            //    defender = group.First().defenderId, // Coge el objeto DefenderDto del primer elemento del grupo
            //    article = group.Select(s => s.articleId == s.articleId), // Ordena y selecciona los ArticleDto
            //    status = group.First().status
            //})
            //.ToList();

            List<StockDto> var = await context.stocks.Select(
                stock => new StockDto { 
                    stockId = stock.stockId,
                    defender = new DefenderDto() {
                        defenderId = stock.Defender.defenderId,
                        defenderName = stock.Defender.defenderName,
                        defenderBalance = stock.Defender.balance,
                        defenderShot = stock.Defender.shot
                    },
                    article = new ArticleDto(){
                        articleId = stock.Article.articleId,
                        articleName = stock.Article.articleName,
                        articlePrice = stock.Article.articlePrice,
                        sco = new ScopeDto() { 
                            scopeId = stock.sco.scopeId,

                        } 

                    }
                }
                )
            

            return var;

        }
    }
}
