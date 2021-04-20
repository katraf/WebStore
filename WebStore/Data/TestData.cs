using System.Collections.Generic;
using WebStore.Models;

namespace WebStore.Data
{
    internal static class TestData
    {
        public static List<Employee> Employees { get;  } = new()
        {
            new Employee { Id = 1, LastName = "Иванов", FirstName = "Иван", Patronymic = "Иванович", Age = 18 },
            new Employee { Id = 2, LastName = "Петров", FirstName = "Петя", Patronymic = "Максимович", Age = 81 },
            new Employee { Id = 3, LastName = "Сидоров", FirstName = "Иван", Patronymic = "Петрович", Age = 58 },
        };
    }
}
