using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VMS.Domain.Entity
{
    public class VehicleType
    {
        [Key]
        public long Id { get; set; }
        public string VehicleName { get; set; }
    }
}
