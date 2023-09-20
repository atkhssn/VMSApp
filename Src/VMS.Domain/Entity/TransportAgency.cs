using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VMS.Domain.Entities;

namespace VMS.Domain.Entity
{
    public class TransportAgency : BaseEntity
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Owner { get; set; }
        public int PhoneNumber { get; set; }
        public string Address { get; set; }
    }
}
