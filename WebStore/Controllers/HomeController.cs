using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebStore.Models;

namespace WebStore.Controllers
{
    public class HomeController : Controller
    {
        private static readonly List<Employee> _Employees = new()
        {
            new Employee { Id = 1, LastName = "Иванов", FirstName = "Иван", Patronymic = "Иванович", Age = 18 },
            new Employee { Id = 2, LastName = "Петров", FirstName = "Петя", Patronymic = "Максимович", Age = 81 },
            new Employee { Id = 3, LastName = "Сидоров", FirstName = "Иван", Patronymic = "Петрович", Age = 58 },
        };
        
        public IActionResult Index()
        {
            return View();
            //return Content("First Controller action");
        }

        public IActionResult SecondAction(string id) => Content($"Action with value id:{id}");

        public IActionResult Employees()
        {
            return View(model: _Employees);
        }
    }
}
