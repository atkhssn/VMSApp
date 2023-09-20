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
    public class MaintenancePartsRepository : Repository<MaintenanceParts>, IMaintenancePartsRepository
    {
        public MaintenancePartsRepository(DbContext context) : base(context)
        {
        }
    }
}
