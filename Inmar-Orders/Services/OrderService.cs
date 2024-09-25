using Inmar_Orders.Models;

namespace Inmar_Orders.Services
{
    public class OrderService : IOrderService
    {
        private readonly List<Order> _orders = new List<Order>
        {
            new Order
            {
                Id = 1,
                OrderDate = new DateTime(2023, 06, 30, 10, 0, 0),
                TotalAmount = 200.50m,
                Status = "Completed",
                Items = new List<OrderItem>
                {
                    new OrderItem { ProductId = 101, ProductName = "Product A", Quantity = 2 }
                }
            },
            new Order
            {
                Id = 1,
                OrderDate = new DateTime(2023, 06, 30, 10, 0, 0),
                TotalAmount = 200.50m,
                Status = "Completed",
                Items = new List<OrderItem>
                {
                    new OrderItem { ProductId = 101, ProductName = "Product A", Quantity = 2 }
                }
            },
            new Order
            {
                Id = 2,
                OrderDate = new DateTime(2023, 06, 25, 9, 30, 0),
                TotalAmount = 100.00m,
                Status = "Completed",
                Items = new List<OrderItem>
                {
                    new OrderItem { ProductId = 102, ProductName = "Product B", Quantity = 1 }
                }
            }
        };

        public async Task<List<Order>> GetOrderHistoryAsync(int userId)
        {
            var filteredOrders = _orders.Where(order => order.Id == userId).ToList();
            return await Task.FromResult(filteredOrders);
        }
    }
}
