using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VMS.Infrastructure.Model
{
    public  class TollDetailsModel
    {
        public string TollName { get; set; }
        public decimal TollFee { get; set; }
        public decimal TollType { get; set; }
    }
}
