
using CGItest.Models;

namespace CGItest.Factories
{
    internal static class ArticleFactory
    {
        public static List<Article> Articles = new()
        {
           new Article(1, "Bananpulver", null, 14.90M),
           new Article(2, "Hund", "Vovve..", 30),
           new Article(3, "Haregryn", "..", 300.99M),
           new Article(4, "Fjun", null, 1.99M)
        };

        public static Article? CreateArticle(int id)
        {
            var article = Articles.FirstOrDefault(a => a.Id == id);
            return article.Clone();
        }
    public static void AddArticleTemplate(string name, string? description, decimal price)
        {
            var a = new Article(Articles.Count + 1, name, description, price);
            Articles.Add(a);
        }
    }
}
