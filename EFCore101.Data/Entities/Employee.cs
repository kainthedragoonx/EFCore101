using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using EFCore101.Data.Entities.Base;

namespace EFCore101.Data.Entities
{
    [Table("Employees", Schema = "Store")]
    public class Employee:EntityBase
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        [InverseProperty(nameof(Product.EmployeeNavigation))]
        public IEnumerable<Product> Products { get; set; } = new List<Product>();

    }
}
