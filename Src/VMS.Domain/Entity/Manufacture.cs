using System.ComponentModel.DataAnnotations;
using VMS.Domain.Entity;

namespace VMS.Domain.Entities
{
    public class Manufacture : BaseEntity
    {
        [Key]
        public long Id { get; set; }
        public long ManufactureTypeId { get; set; }
        public long ModelTypeId { get; set; }
    }
}
