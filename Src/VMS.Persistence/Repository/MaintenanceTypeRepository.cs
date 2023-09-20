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
    public class MaintenanceTypeRepository : Repository<MaintenanceType>, IMaintenanceTypeRepository
    {
        public MaintenanceTypeRepository(DbContext context)
            : base(context) { }
    }
}
