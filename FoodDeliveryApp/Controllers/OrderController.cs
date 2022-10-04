using FoodDeliveryApp.Models;
using FoodDeliveryApp.ViewModels;
using FoodDeliveryApp.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace FoodDeliveryApp.Controllers
{
    
    public class OrderController : Controller
    {
        IOrderRepository orderRepository;
        Entity context;
        public OrderController(IOrderRepository orderRepository, Entity context)
        {
            this.orderRepository = orderRepository;
            this.context = context;
        }
        [Authorize]
        public IActionResult Index()
        { OrderAndAddressViewModel orderAndAdressViewModel = new OrderAndAddressViewModel();
            List<Order> orders = orderRepository.getAll();
            orderAndAdressViewModel.orders = orders;
            orderAndAdressViewModel.addresses=orderRepository.getAll().Select(e=>e.Address).ToList();
            return View(orderAndAdressViewModel);
        }
        
        //Action for filtering by Address
        public IActionResult getOrderByAddress(string adrress)
        {
            List<Order> orders = orderRepository.getAllByAddress(adrress);
            return PartialView("_Order",orders);
        }
    }
}
