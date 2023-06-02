using System.ComponentModel.DataAnnotations;

namespace CGItest.Models
{
    public class Article
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "2-30 bokstäver.")]
        [MinLength(2, ErrorMessage = "Minst två bokstäver.")]
        [MaxLength(20, ErrorMessage = "Max 30 bokstäver.")]
        public string Name { get; set; } = string.Empty;
        public string? Description { get; set; }
        [Required(ErrorMessage = "Pris obligatoriskt")]
        [Range(0.1, 9999999.99, ErrorMessage = "Pris måste vara mer än 0.1.")]
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
