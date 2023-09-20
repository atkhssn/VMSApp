using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VMS.Domain.Entities;
using VMS.Infrastructure.Model;
using VMS.Persistence;
using static System.Formats.Asn1.AsnWriter;
using VMS.Infrastructure.Utility;
using static VMS.Infrastructure.Utility.EnumCollection;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Hosting;

namespace VMS.Infrastructure.Service
{
    public class DriverService
    {
        private readonly IUnitOfWork _unitOFwork;
        private readonly IHostingEnvironment _environment;

        public DriverService() { }
        public DriverService(IUnitOfWork unitOfWork, IHostingEnvironment environment)
        {
            this._unitOFwork = unitOfWork;
            this._environment = environment;
        }
        public bool Create(DriverModel model)
        {
            try
            {
                var driver = new Driver();

                driver.DName = model.DName;
                driver.Licenceno = model.Licenceno;
                driver.DriverShift = model.DriverShift;
                driver.IsActive = true;

                _unitOFwork.DriverRepository.Add(driver);
                _unitOFwork.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public List<DriverModel> GetAllData()
        {
            var driverList = _unitOFwork.DriverRepository.GetAll().Where(x => x.IsActive == true);
            var viewModel = new List<DriverModel>();

            foreach (var driver in driverList)
            {
                var data = new DriverModel()
                {
                    DId = driver.DId,
                    DName = driver.DName,
                    Licenceno = driver.Licenceno,
                    DriverShift = driver.DriverShift
                };
                viewModel.Add(data);
            }

            return viewModel;
        }

        public DriverModel GetDriver(long id)
        {
            var driver = _unitOFwork.DriverRepository.GetByid(id);
            var driverData = new DriverModel()
            {
                DId = driver.DId,
                DName = driver.DName,
                DriverShift = driver.DriverShift,
                Licenceno = driver.Licenceno,
            };
            return driverData;
        }

        public bool UpdateDriver(DriverModel model)
        {
            var driver = _unitOFwork.DriverRepository.GetByid(model.DId);

            if (driver != null)
            {
                driver.DName = model.DName;
                driver.DriverShift = model.DriverShift;
                driver.Licenceno = model.Licenceno;

                _unitOFwork.DriverRepository.Update(driver);
                _unitOFwork.SaveChanges();
                return true;
            }

            return false;
        }

        public bool DeleteDriver(long id)
        {
            var driver = _unitOFwork.DriverRepository.GetByid(id);

            if (driver != null)
            {
                driver.IsActive = false;
                _unitOFwork.DriverRepository.Update(driver);
                _unitOFwork.SaveChanges();

                return true;
            }
            return false;
        }

        // Upload methods
        public string UploadImage(string fileName, IFormFile formFile) // Image file path
        {
            Random random = new Random();
            string filePath = $"ProjectFiles/Drivers/Photo_" + random.Next(0000, 9999) + fileName;
            return UploadContent(filePath, formFile);
        }

        public string UploadLicense(string fileName, IFormFile formFile) // License file path
        {
            Random random = new Random();
            string filePath = $"ProjectFiles/Drivers/License_" + random.Next(00000, 99999) + "_" + fileName;
            return UploadContent(filePath, formFile);
        }

        public string UploadNid(string fileName, IFormFile formFile) // Nid file path
        {
            Random random = new Random();
            string filePath = $"ProjectFiles/Drivers/Nid_" + random.Next(000000, 999999) + "_" + fileName;
            return UploadContent(filePath, formFile);
        }

        public string UploadContent(string filePath, IFormFile formFile) // Copy local machine to server machine
        {
            string folderPath = _environment.WebRootPath;

            string fullPath = Path.Combine(folderPath, filePath);
            using (FileStream stream = new FileStream(fullPath, FileMode.Create))
            {
                formFile.CopyToAsync(stream);
            }
            return fullPath;
        }

    }
}
