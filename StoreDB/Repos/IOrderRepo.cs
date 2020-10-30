using StoreDB.Models;
using System.Collections.Generic;

namespace StoreDB
{
    public interface IOrderRepo
    {
         void AddOrder(Order order);
         void UpdateOrder(Order order);
         Order GetOrderById(int id);
         Order GetOrderByUserId(int id);
         Order GetOrderByLocationId(int id);
         List<Order> GetAllOrdersByLocationId(int id);
         List<Order> GetAllOrdersByUserId(int id);
         void DeleteOrder(Order order);
    }
}