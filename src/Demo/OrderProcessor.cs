public class OrderProcessor
{
    public decimal CalculateTotal(List<OrderItem> items)
    {
        return items.Sum(item => item.Price * item.Quantity);
    }
}