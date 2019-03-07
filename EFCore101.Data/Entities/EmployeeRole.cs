using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using EFCore101.Data.Entities.Base;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace EFCore101.Data.Entities
{
    [Table("EmployeeProductRoles", Schema = "Store")]
    public class EmployeeProductRole: EntityBase
    {
        public int EmployeeId { get; set; }
        [ForeignKey("EmployeeId")]
        public Employee EmployeeNavigation { get; set; }

        public int RoleId { get; set; }
        [ForeignKey("RoleId")]
        public Role RoleNavigation { get; set; }

        public int ProductId { get; set; }
        [ForeignKey("ProductId")]
        public Product ProductNavigation { get; set; }

    }
}
