using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VMS.Domain.Entity;
using VMS.Perasistance.BaseRepo;

namespace VMS.Persistence.Repository.IRepository
{
    public interface IManufactureTypeRepository : IRepository<ManufactureType>
    {
        Task<long> ManufactureTypeIdAsync(string ManufactureName);
        Task<long> GetIdAsync(string modelName);
    }
}
