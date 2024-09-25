namespace Inmar_Orders.Models
{
    public interface IOrderService
    {
        Task<List<Order>> GetOrderHistoryAsync(int userId);
    }
}
