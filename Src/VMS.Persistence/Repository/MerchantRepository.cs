using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VMS.Domain.Entity;
using VMS.Perasistance.BaseRepo;
using VMS.Persistence.Repository.IRepository;

namespace VMS.Persistence.Repository
{
    public class MerchantRepository : Repository<Merchant>, IMerchantRepository
    {

        public MerchantRepository(DbContext context) : base(context) { }
    }
}
