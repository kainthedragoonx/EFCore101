using System;
using System.ComponentModel.DataAnnotations;

namespace EFCore101.Data.Entities.Base
{
    public abstract class EntityBase
    {
        [Key()]
        public int Id { get; set; }
        [Timestamp]
        public byte[] RowVersion { get; set; }
        public DateTime Created { get; set; }
        public DateTime Modified { get; set; }
    }
}