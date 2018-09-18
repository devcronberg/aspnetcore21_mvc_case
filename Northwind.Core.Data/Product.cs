using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Northwind.Core.Data
{
    [Table("Product")]
    public class Product
    {
        public int Id { get; set; }
        public string Productname { get; set; }
        public double UnitPrice { get; set; }
        public bool Discontinued { get; set; }
    }
}
