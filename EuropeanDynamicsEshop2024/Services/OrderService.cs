﻿using EuropeanDynamicsEshop2024.Dtos;
using EuropeanDynamicsEshop2024.Models;
using EuropeanDynamicsEshop2024.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EuropeanDynamicsEshop2024.Services;

public class OrderService : IOrderService
{
    private readonly EshopDbContext _context;

    public OrderService(EshopDbContext context)
    {
        _context = context;
    }

    public OrderDto CreateOrder(int customerId)
    {
        var customer = _context.Customers.Where(customer => customer.Id == customerId).FirstOrDefault();
        if (customer == null)
        {
            return null;
        }
        var order = new Order()
        {
            OrderDate = DateTime.Now,
            Customer = customer,
        };
        _context.Orders.Add(order);
        _context.SaveChanges();
        return new OrderDto
        {
             CustomerId = order.Customer.Id,
             OrderDate = order.OrderDate,
             CustomerName = order.Customer.FistName + " " + order.Customer.LastName,
             Id = order.Id
        };
    }

}
