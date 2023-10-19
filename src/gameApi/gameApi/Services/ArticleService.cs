using gameApi.DTOs;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query.SqlExpressions;

namespace gameApi.Services
{
    public class ArticleService
    {

        public static async Task<List<ArticleDto>> GetArticles(ApplicationDbContext context)
        {
            var Articles = await context.articles.Select(x => new ArticleDto
            {
                articleId = x.articleId,
                articleName = x.articleName,
                articlePrice = x.articlePrice,
                scopeValue = x.Scope.scopeValue
            })
            .ToListAsync();
 

            return Articles;
           
        }
    }
}
