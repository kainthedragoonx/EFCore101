using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using EFCore101.Data.Entities.Base;

namespace EFCore101.Data.Entities
{
    [Table("Categories", Schema = "Store")]
    public class Category: EntityBase
    {
        [MaxLength(50)]
        [Required]
        [Column(TypeName = "varchar(50)")]
        public string Name { get; set; }

        [InverseProperty(nameof(Product.CategoryNavigation))]
        public List<Product> Products { get; set; }
    }
}
