﻿using PrzykladoweKolokwium2_1.Models;
using PrzykladoweKolokwium2_1.Models.DTOs;

namespace PrzykladoweKolokwium2_1.Services
{
    public interface IDbService
    {
        Task<ICollection<Order>> GetOrdersData(string? clientLastName);
        Task<bool> DoesClientExist(int clientID);
        Task<bool> DoesEmployeeExist(int employeeID);
        Task AddNewOrder(Order order);
        Task<Pastry?> GetPastryByName(string name);
        Task AddOrderPastries(IEnumerable<OrderPastry> orderPastries);
    }
}
