using EuropeanDynamicsEshop2024.Models;
using EuropeanDynamicsEshop2024.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EshopApi.Controllers;


[Route("api/[controller]")]
[ApiController]
public class OrderController : ControllerBase
{
    private readonly IOrderService _orderService;

    public OrderController(IOrderService orderService)
    {
        _orderService = orderService;
    }

    [HttpPost("{id}")]
    public Order CreateOrder(int id)
    {
        return _orderService.CreateOrder(id);
    }
}
