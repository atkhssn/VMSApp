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
using VMS.Domain.Entity;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace VMS.Persistence.Repository
{
    public class VehicleRepository : Repository<Vehicle>, IVehicleRepository
    {
        public VehicleRepository(DbContext context)
            : base(context) { }

        public void Add(Maintenance maintain)
        {
            throw new NotImplementedException();
        }

        public long? LastObjectId()
        {
            var data = _Entities.AsQueryable();
           
            try
            {
               

               
                    long? result = data.AsNoTracking().LastOrDefault().Id;
                return result;
            }
            catch
            {
                return 0;

            }
            
        }
    }
}
