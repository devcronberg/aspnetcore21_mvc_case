using System;

namespace Northwind.Core.Data.ConsoleTest
{
    class Program
    {
        static void Main(string[] args)
        {
            NorthwindRepository r = new NorthwindRepository();
            //var empl = r.GetAllEmployees(i => i.ReportsTo == 2, i => i.LastName);
            //var empl = r.GetAllEmployees(i => i.LastName);
            var empl = r.GetAllEmployees();
            foreach (var item in empl)
            {
                Console.WriteLine($"{item.Id}: {item.FirstName} {item.LastName}");
            }
        }
    }
}
