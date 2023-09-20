using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VMS.Domain.Entities;

namespace VMS.Domain.Entity
{
    public class Maintenance : BaseEntity
    {
        public long VId { get; set; }
        public long VehicleId { get; set; }
        public long TripId { get; set; }
        public DateTime ServiceDate { get; set; }
        public string Description { get; set; }
        public bool Status { get; set; }
    }
}
