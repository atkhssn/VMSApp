using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VMS.Domain.Entities;

namespace VMS.Domain.Entity
{
    public  class MaintenanceParts:BaseEntity
    {
        public long Id { get; set; }
        public string PartsName { get; set; }
        public decimal PartsPrice{ get; set; }
        public long MaintainceId{ get; set; }


    }
}
