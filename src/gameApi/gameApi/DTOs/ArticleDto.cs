namespace gameApi.DTOs
{
    public class ArticleDto
    {
        public int articleId { get; set; }
        public string articleName { get; set; }
        public int articlePrice { get; set; }
        public ScopeDto sco { get; set; }
    }
}
