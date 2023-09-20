﻿using VMS.Persistence.Repository;
using VMS.Persistence.Repository.IRepository;

namespace VMS.Persistence
{
    public interface IUnitOfWork : IDisposable
    {
        public IVehicleRepository VehicleRepository { get; }
        public IManufactureRepository ManufactureRepository { get; }
        public IVehicleTypeRepository vehicleTypeRepository { get; }
        public IManufactureTypeRepository ManufactureTypeRepository { get; }
        public IModelTypeRepository ModelTypeRepository { get; }
        public IMaintenanceRepository MaintenanceRepository { get; }
        public IMaintenanceTypeRepository MaintenanceTypeRepository { get; }
        public ITransportAgencyRepository TransportAgencyRepository { get; }
        public ITripExpensesRepository TripExpensesRepository { get; }
        public IMerchantRepository MerchantRepository { get; }
        public IDriverRepository DriverRepository { get; }
        public IMaintenancePartsRepository MaintenancePartsRepository { get; }

        bool SaveChanges();
    }
}
