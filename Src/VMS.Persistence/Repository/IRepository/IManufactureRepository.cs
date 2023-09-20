using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VMS.Domain.Entities;
using VMS.Perasistance.BaseRepo;

namespace VMS.Persistence.Repository.IRepository
{
    public interface IManufactureRepository : IRepository<Manufacture>
    {
        List<Manufacture> GetActiveManufacture();
        List<object> GetModel(long id);
        long IsManufactureDuplicate(long manufactureType, long modelType);
    }
}
