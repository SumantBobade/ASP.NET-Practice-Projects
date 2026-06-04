using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using PracticeWebApp.Models;

namespace PracticeWebApp.Controllers;

public class CustomerController : Controller
{
    public static List<Customer> customers = new List<Customer>()
    {
        new Customer(){Id=1, Name="John Doe", Amount=100.50},
        new Customer(){Id=2, Name="Jane Smith", Amount=200.75},
        new Customer(){Id=3, Name="Bob Johnson", Amount=150.25}
    };
    public IActionResult Index()
    {
        ViewBag.Message = "Customer Management System";
        ViewBag.CustomersCount = customers.Count();
        ViewBag.CustomersList = customers;
        return View();
    }

    public IActionResult Details()
    {
        return View();
    }   

     public IActionResult Message()
    {
        return View();
    }
}