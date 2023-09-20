using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VMS.Domain.Entities;
using VMS.Domain.Entity;
using VMS.Infrastructure.Model;
using VMS.Persistence;
using Microsoft.EntityFrameworkCore;
using VMS.Infrastructure.Utility;

namespace VMS.Infrastructure.Service
{
    public class MaintenanceService
    {
        private readonly IUnitOfWork _unitOfWork;

        public MaintenanceService() { }

        public MaintenanceService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public bool Create(List<MaintenanceModel> model)
        {
            try
            {
                int z = 0;
                foreach (var maintenance in model)
                {
                    if (z > 0)
                    {
                        break;
                    }
                    var maintaince = new Maintenance()
                    {
                        VehicleId = maintenance.VehicleId,
                        TripId = maintenance.TripId,
                        ServiceDate = maintenance.ServiceDate,
                        Status = maintenance.Status,
                        Description = maintenance.Description,
                        CreatedOn = DateTime.Now
                    };
                    z++;

                    _unitOfWork.MaintenanceRepository.Add(maintaince);
                    _unitOfWork.SaveChanges();

                    var maintainceId = _unitOfWork.MaintenanceRepository.LastId();

                    try
                    {
                        bool isPartsCreate = CreateParts(model, maintainceId);
                        return isPartsCreate;
                    }
                    catch
                    {
                        return false;
                    }
                }







                return true;
            }
            catch
            {
                return false;
            }
        }


        public bool CreateParts(List<MaintenanceModel> model, long maintainceId)
        {
            if (model is null | maintainceId < 1)
            {
                return false;
            }
            var partsList = new List<MaintenanceParts>();

            foreach (var parts in model)
            {
                if (parts.PartsPrice < 1 | parts.PartsName is null)
                {
                    continue;
                }
                var partObject = new MaintenanceParts()
                {
                    PartsName = parts.PartsName,
                    PartsPrice = parts.PartsPrice,
                    MaintainceId = maintainceId,
                    CreatedOn = DateTime.Now

                };
                partsList.Add(partObject);
            }

            try
            {
                _unitOfWork.MaintenancePartsRepository.AddRangeAsync(partsList);
                _unitOfWork.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }

        }


        public List<Maintenance> GetAllData()
        {
            var maintenanceData = _unitOfWork.MaintenanceRepository.GetAll();
            return (List<Maintenance>)maintenanceData;
        }

        public object GetAllMaintenanceTypes(int id)
        {
            throw new NotImplementedException();
        }

        public List<MaintenanceModel> GetDataTable()
        {
            List<MaintenanceModel> MaintenanceModels = new List<MaintenanceModel>();
            var maintenlist = GetAllData();
            foreach (var maintain in maintenlist)
            {
                MaintenanceModel model = new MaintenanceModel();
                var maintenance = _unitOfWork.MaintenanceRepository.GetByid(maintain.VId);
                model.VehicleId = _unitOfWork.MaintenanceRepository.GetByid(maintain.Id).Id;
                model.ServiceDate = maintain.ServiceDate;
                model.Description = maintain.Description;
                //model.PartsName = maintain.PartsName;
                //model.PartsPrice = maintain.PartsPrice;
                //model.WorkshopBill = maintain.WorkshopBill;
                model.Status = maintain.Status;
                MaintenanceModels.Add(model);
            }

            return MaintenanceModels;
        }

        public async Task<List<object>> GetDataTableFilterdAsync(DataTableAjaxRequest dataTable)
        {
            //var data= await _unitOFWork.VehicleRepository

            return new List<object> { dataTable };
        }

        public object GetDisableField(long id)
        {
            throw new NotImplementedException();
        }


    }
}
