using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VMS.Domain.Entities;
using VMS.Domain.Entity;
using VMS.Perasistance.BaseRepo;

namespace VMS.Persistence.Repository.IRepository
{
    public interface IVehicleRepository : IRepository<Vehicle>
    {
        void Add(Maintenance maintain);
        long? LastObjectId();

    }
}
