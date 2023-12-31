﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VMS.Infrastructure.Model
{
    public class MaintenanceModel
    {
        public long VehicleId { get; set; }
        public long TripId { get; set; }
        public DateTime ServiceDate { get; set; }
        public string Description { get; set; }
        public string PartsName { get; set; }
        public  decimal PartsPrice { get; set; }
        public decimal WorkshopBill { get; set; }
        public bool Status { get; set; }
    }
}
