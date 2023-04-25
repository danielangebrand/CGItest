namespace CGItest.Models
{
    public class OrderRow
    {
        public int RowNumber { get; set; } = 1;
        public Article Article { get; set; } = null;
        public int Quantity { get; set; }
        public decimal Sum => Quantity * Article.Price;

    }
}
