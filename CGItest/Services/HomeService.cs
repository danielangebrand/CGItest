using CGItest.Data.Factories;
using CGItest.Models;

namespace CGItest.Services
{
    public class HomeService
    {
        public List<Order> Orders = new();
        public List<Article> Articles = new();
        public HomeService()
        {
            Articles = GetArticles();
            var order1 = new Order { Id = 1, Name = "Ben Dover" };
            order1.OrderRows.Add(new OrderRow { RowNumber = 1, Article = ArticleFactory.CreateArticle(1), Quantity = 2 });
            order1.OrderRows.Add(new OrderRow { RowNumber = 2, Article = ArticleFactory.CreateArticle(3), Quantity = 1 });
            Orders.Add(order1);

            var order2 = new Order { Id = 2, Name = "Lars Huldvigssohn" };
            order2.OrderRows.Add(new OrderRow { RowNumber = 1, Article = ArticleFactory.CreateArticle(1), Quantity = 4 });
            order2.OrderRows.Add(new OrderRow { RowNumber = 2, Article = ArticleFactory.CreateArticle(2), Quantity = 2 });
            Orders.Add(order2);

            var order3 = new Order { Id = 3, Name = "Hans af Fisk" };
            order3.OrderRows.Add(new OrderRow { RowNumber = 1, Article = ArticleFactory.CreateArticle(4), Quantity = 1000 });
            order3.OrderRows.Add(new OrderRow { RowNumber = 2, Article = ArticleFactory.CreateArticle(3), Quantity = 2 });
            Orders.Add(order3);
        }

        public List<Order> GetOrders() => Orders;
        public static List<Article> GetArticles() => ArticleFactory.Articles;
        public Article GetArticleById(int id) => Articles.FirstOrDefault(a => a.Id == id);
        public List<OrderRow> GetOrderRowsByArticleId(int id) => Orders.SelectMany(o => o.OrderRows.Where(l => l.Article.Id == id)).ToList();
    }
}

