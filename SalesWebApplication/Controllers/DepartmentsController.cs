using Microsoft.AspNetCore.Mvc;
using SalesWebApplication.Models;
using System.Collections.Generic;

namespace SalesWebApplication.Controllers
{
    public class DepartmentsController : Controller
    {
        public IActionResult Index()
        {

            List<Department> list = new List<Department>();
            list.Add(new Department { Id= 1, Name= "Electro"});
            list.Add(new Department { Id = 2, Name = "Fashion" });


            return View(list);
        }
    }
}
