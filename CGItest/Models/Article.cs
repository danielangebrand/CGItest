using System.ComponentModel.DataAnnotations;

namespace CGItest.Models
{
    public class Article
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string? Description { get; set; }
        public decimal Price { get; set; }

        public Article(int id, string name, string? description, decimal price)
        {
            Name = name;
            Description = description;
            Price = price;
            Id = id;
        }
        // Template enbart..
        public Article()
        {
            
        }
        public Article Clone() => new(Id, Name, Description, Price);
    }
}
