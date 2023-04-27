namespace CGItest.Models
{
    public class OrderRow
    {
        public int RowNumber { get; set; } = 1;
        public Article Article { get; set; }
        public int Quantity { get; set; }
        public decimal Sum => (decimal)Quantity * Article.Price;

    }
}
