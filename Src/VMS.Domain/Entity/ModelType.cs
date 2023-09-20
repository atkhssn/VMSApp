using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VMS.Domain.Entity
{
    public class ModelType
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public long ManufactureType { get; set; }
    }
}
