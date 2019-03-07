using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using EFCore101.Data.Entities.Base;

namespace EFCore101.Data.Entities
{
    [Table("Roles",Schema = "Store")]
    public class Role:EntityBase
    {
        [MaxLength(50)]
        public string Name { get; set; }
    }
}
