using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Linq.Expressions;

namespace Northwind.Core.Data
{
    public class NorthwindRepository
    {

        public List<Product> GetAllProducts()
        {
            using (NorthwindContext c = new NorthwindContext())
            {
                return c.Products.ToList();
            }
        }

        public Product GetProduct(int id)
        {
            using (NorthwindContext c = new NorthwindContext())
            {
                return c.Products.Find(id);
            }
        }

        public void UpdateProductName(int id, string productname)
        {
            using (NorthwindContext c = new NorthwindContext())
            {
                var p = c.Products.Find(id);
                if (p != null)
                {
                    p.Productname = productname;
                    c.SaveChanges();
                }
            }
        }


        public List<Employee> GetAllEmployees() {
            using (NorthwindContext c = new NorthwindContext())
            {
                return c.Employees.ToList();
            }
        }

        public List<Employee> GetAllEmployees(Expression<Func<Employee, bool>> where, Func<Employee, Object> orderBy = null)
        {
            if (orderBy == null)
                orderBy = i => i.Id;
            using (NorthwindContext c = new NorthwindContext())
            {
                return c.Employees.Where(where).OrderBy(orderBy).ToList();
            }
        }

        public List<Employee> GetAllEmployees(Func<Employee, Object> orderBy = null)
        {
            if (orderBy == null)
                orderBy = i => i.Id;
            using (NorthwindContext c = new NorthwindContext())
            {
                return c.Employees.OrderBy(orderBy).ToList();
            }
        }

    }
}
