using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VMS.Infrastructure.Model
{
    public class TransportAgencyModel
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Owner { get; set; }
        public int PhoneNumber { get; set; }
        public string Address { get; set; }
    }
}
