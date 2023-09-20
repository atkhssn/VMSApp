using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VMS.Domain.Entities;

namespace VMS.Domain.Entity
{
    public  class TollDetails:BaseEntity
    {

        public long  Id { get; set; }

        public string TollName { get; set; }
        public decimal TollFee { get; set; }
        public decimal TollType { get; set; }
        public DateTime TollDate { get; set; }
        public long TripExpensesId { get; set; }  
    }
}
