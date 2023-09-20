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
    public class MaintenanceRepositoty : Repository<Maintenance>, IMaintenanceRepository
    {
        public MaintenanceRepositoty(DbContext context)
            : base(context) { }


        public long LastId()
        {
            var entity = _Entities.AsQueryable();

            var LastId = entity.AsNoTracking().ToList().LastOrDefault().Id;

            return LastId;
        }

    }
}
