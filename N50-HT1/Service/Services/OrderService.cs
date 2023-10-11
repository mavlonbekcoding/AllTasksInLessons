using N50_HT1.Data.Model;
using N50_HT1.Service.Interfaces;
using System.Diagnostics;

namespace N50_HT1.Service.Services;

public class OrderService : IOrderService
{
    private List<Order> orders = new List<Order>();
    public Order Create(Order order)
    {
         orders.Add(order);
        return order;
    }
}
