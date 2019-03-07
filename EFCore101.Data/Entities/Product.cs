using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using EFCore101.Data.Entities.Base;

namespace EFCore101.Data.Entities
{
    [Table("Products",Schema = "Store")]
    public class Product : EntityBase
    {
        [MaxLength(100)]
        [Required]
        [Column(TypeName = "varchar(100)")]
        public  string Name { get; set; }
        public int CategoryId { get; set; }

        [ForeignKey(nameof(CategoryId))]
        public Category CategoryNavigation { get; set; }

        //public int EmployeeId { get; set; }
        //[ForeignKey(nameof(EmployeeId))]
        //public Employee EmployeeNavigation { get; set; }
    }
}
