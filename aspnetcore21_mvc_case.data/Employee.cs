using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace aspnetcore21_mvc_case.data
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
    }
}
