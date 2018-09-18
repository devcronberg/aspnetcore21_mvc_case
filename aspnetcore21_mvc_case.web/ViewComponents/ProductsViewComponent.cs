using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aspnetcore21_mvc_case.web.ViewComponents
{
    public class ProductsViewComponent : ViewComponent
    {
        private Northwind.Core.Data.NorthwindRepository northwindRepository;

        public ProductsViewComponent(Northwind.Core.Data.NorthwindRepository northwindRepository)
        {
            this.northwindRepository = northwindRepository;
        }
        public IViewComponentResult Invoke(bool admin)
        {
            ViewBag.admin = admin;
            return View(northwindRepository.GetAllProducts());
        }
    }
 

}
