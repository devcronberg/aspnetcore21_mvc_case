using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Linq.Expressions;

namespace aspnetcore21_mvc_case.data
{
    public class NorthwindRepository
    {
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
