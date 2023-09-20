using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VMS.Domain.Entities;

namespace VMS.Domain.Entities
{
    public class Driver : BaseEntity
    {
        [Key]
        public long DId { get; set; }
        public string DName { get; set; }
        public string Licenceno { get; set; }
        public DateTime LicenceValidation { get; set; }
        public string NIDNumber { get; set; }
        public string DriverShift { get; set; }
        public string DriverType { get; set; }
        public string DriverPhotoUrl { get; set; }
        public string LicenceDocumentUrl { get; set; }
        public string NidDocumentUrl { get; set; }
        public bool IsAvailable { get; set; }
        public bool IsActive { get; set; }
    }
}
