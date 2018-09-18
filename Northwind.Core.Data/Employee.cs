using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Northwind.Core.Data
{
    [Table("Employee")]
    public class Employee
    {
        public int Id { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Title { get; set; }
        public string TitleOfCourtesy { get; set; }
        public DateTime BirthDate { get; set; }        
        public string Notes { get; set; }
        public int? ReportsTo { get; set; }
    }
}
