using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VMS.Domain.Entity;

namespace VMS.Infrastructure.Model
{
    public class ManufactureModel
    {
        public long ManufactureId { get; set; }
        public string ManufactureName { get; set; }
        public string ModelName { get; set; }
    }
}
