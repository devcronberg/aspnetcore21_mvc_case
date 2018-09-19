using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using aspnetcore21_mvc_case.web.Models.Configuration;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace aspnetcore21_mvc_case.web.Controllers
{
    public class HomeController : Controller
    {

        private AppSettings appSetting;
        private ILogger logger;
        private Northwind.Core.Data.NorthwindRepository northwindRepository;

        public HomeController(AppSettings appSetting, ILogger<HomeController> logger, Northwind.Core.Data.NorthwindRepository northwindRepository)
        {
            this.appSetting = appSetting;
            this.logger = logger;
            this.northwindRepository = northwindRepository;
        }

        [HttpGet("~/", Name ="home")]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet("~/employees", Name = "employees")]
        public IActionResult Employees()
        {
            var e = northwindRepository.GetAllEmployees(i => i.LastName);
            return View(e);
        }

        [HttpGet("~/products", Name = "products")]
        public IActionResult Products()
        {         
            return View();
        }

        [HttpGet("~/admin/products/", Name = "adminproducts")]
        public IActionResult AdminProducts()
        {          
            return View(northwindRepository.GetAllProducts());
        }

        [HttpGet("~/admin/products/{id:int}", Name = "editproduct")]
        public IActionResult EditProduct(int id)
        {
            return View(northwindRepository.GetProduct(id));
        }

        [HttpPost("~/admin/saveproduct")]
        public IActionResult SaveProduct(int id, string productname)
        {
            northwindRepository.UpdateProductName(id, productname);
            return RedirectToAction("adminproducts");
        }

        [HttpGet("~/admin/customers/", Name = "admincustomers")]
        public IActionResult AdminCustomers()
        {
            return View();
        }


        [HttpGet("~/admin/customersjson/", Name = "admincustomersjson")]
        public IActionResult AdminCustomersJson()
        {
            return Json(northwindRepository.GetAllCustomers());
        }


    }
}