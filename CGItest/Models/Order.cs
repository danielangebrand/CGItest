using System.ComponentModel.DataAnnotations;

namespace CGItest.Models
{
    public class Order
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public List<OrderRow> OrderRows { get; set; }
        public Order()
        {
            OrderRows = new();
        }
    }
}
