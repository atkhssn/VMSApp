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

namespace VMS.App.Controllers
{
    public class VehicleController : Controller
    {
        protected readonly VehicleService _vehicleService;
        public ILifetimeScope Scope { get; set; }

        public VehicleController(ILifetimeScope lifeScope, VehicleService VehicleService)
        {
            Scope = lifeScope;
            _vehicleService = VehicleService;
        }

        public async Task<IActionResult> Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(VehicleModel model)
        {
            
                model.PhotoUrl = _vehicleService.UplodeImage(model.Photo.FileName, model.Photo).Result;
                model.DocumentUrl = _vehicleService.UplodeDocument(
                    model.Document.FileName,
                    model.Document
                );
            
          

            _vehicleService.Create(model);

            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Edit(VehicleModel model)
        {
            bool IsEdit = _vehicleService.Edit(model);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public JsonResult GetSingleObject(long id)
        {
            var VehicelObject = _vehicleService.SearchEdit(id);
            return Json(VehicelObject);
        } 
        
        [HttpGet]
        public JsonResult SoftDelete(long id)
        {
            var VehicelObject = _vehicleService.SoftDelete(id);
            return Json(VehicelObject);
        }

        public IActionResult GetAll()
        {
            var vehicleService2 = new DataTableAjaxRequest(Request);
            var data = _vehicleService.GetDataTable();

            return Json(data);
        }

        public IActionResult GetModelYear()
        {
            var vehicleService = Scope.Resolve<VehicleService>();
            var data = vehicleService.ModelYear();

            return Json(data);
        }

        public JsonResult GetById()
        {
            return Json(null);
        }

        public JsonResult GetVehicleType()
        {
            var vehicleList = _vehicleService.GetAllVehicleType();
            return Json(vehicleList);
        }

        public JsonResult GetAllTableData()
        {
            //var vehicleService2 = new DataTableAjaxRequest(Request);
            var data = _vehicleService.GetDataTable();

            var jsonResult = Json(data);
            return jsonResult;
        }
    }
}
