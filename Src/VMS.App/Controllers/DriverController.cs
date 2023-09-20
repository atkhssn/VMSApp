using Autofac;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Hosting;
using VMS.Infrastructure;
using IHostingEnvironment = Microsoft.AspNetCore.Hosting.IHostingEnvironment;
using VMS.Infrastructure.Model;
using VMS.Infrastructure.Service;
using System;
using VMS.Infrastructure.Utility;
using Microsoft.AspNetCore.Http.HttpResults;
using System.IO;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Net.NetworkInformation;

namespace VMS.App.Controllers
{
    public class DriverController : Controller
    {
        public IHostingEnvironment _Environment;
        public DriverService _driverService { get; set; }
        public ILifetimeScope Scope { get; set; }
        public DriverController(ILifetimeScope lifeScope,DriverService Driverservice,IHostingEnvironment environment)
        {
            Scope= lifeScope;
            _Environment= environment;
            _driverService = Driverservice; 
        }
        public IActionResult Index()
        {
            var data = new DriverModel()
            {
                Drivers = _driverService.GetAllData()
            };

            return View(data);
        }
        [HttpPost]
        public IActionResult Create(DriverModel model)
        {
            model.DriverPhotoUrl = _driverService.UploadImage(model.DriverPhoto.FileName, model.DriverPhoto);
            model.LicenceDocumentUrl = _driverService.UploadLicense(model.LicenceDocument.FileName, model.LicenceDocument);
            model.NidDocumentUrl = _driverService.UploadNid(model.NidDocument.FileName, model.NidDocument);
            _driverService.Create(model);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Edit(long id)
        {
            var driver = _driverService.GetDriver(id);
            return View(driver);
        }

        [HttpPost]
        public IActionResult Update(DriverModel model)
        {
            bool isUpdate = _driverService.UpdateDriver(model);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Delete(DriverModel model)
        {
            bool isDelete = _driverService.DeleteDriver(model.DId);
            return RedirectToAction("Index");
        }
    }
}

