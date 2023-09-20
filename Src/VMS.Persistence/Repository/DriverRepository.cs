using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VMS.Domain.Entities;
using VMS.Perasistance.BaseRepo;
using VMS.Domain.Database;
using VMS.Persistence.Repository.IRepository;

namespace VMS.Persistence.Repository
{
    public class DriverRepository : Repository<Driver>, IDriverRepository
    {
        public DriverRepository(DbContext context) : base(context) 
        {
        }
    }
}
