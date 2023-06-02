using System.ComponentModel.DataAnnotations;

namespace CGItest.Models
{
    public class Order
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "2-30 bokstäver.")]
        [MinLength(2, ErrorMessage = "Minst två bokstäver.")] 
        [MaxLength(20, ErrorMessage = "Max 30 bokstäver.")]
        public string Name { get; set; } = string.Empty;
        [Required]
        public List<OrderRow> OrderRows { get; set; } = new();
        public Order()
        {
        }
    }
}
