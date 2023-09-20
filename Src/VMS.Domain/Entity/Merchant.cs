using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VMS.Domain.Entities;

namespace VMS.Domain.Entity
{
    public class Merchant : BaseEntity
    {
        [Key]
        public long Id { get; set; }
        public string MerchantName { get; set; }
        public string DepartmentName { get; set; }
        public string ResponsiblePerson { get; set; }
        public string MerchantPhone { get; set; }
        public string MerchantEmail { get; set; }
    }
}
