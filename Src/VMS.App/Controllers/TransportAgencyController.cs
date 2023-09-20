using Microsoft.AspNetCore.Mvc;
using VMS.Domain.Entity;
using VMS.Infrastructure.Model;
using VMS.Infrastructure.Service;

namespace VMS.App.Controllers
{
    public class TransportAgencyController : Controller
    {
        public readonly TransportAgencyService AgencyService;

        public TransportAgencyController(TransportAgencyService transportAgency)
        {
            AgencyService = transportAgency;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(TransportAgencyModel transportAgency)
        {
            bool IsCreate = AgencyService.Create(transportAgency);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Edit(TransportAgencyModel transportAgency)
        {
            bool IsCreate = AgencyService.EditAsync(transportAgency).Result;
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Delete(long transportAgencyId)
        {
            bool IsCreate = AgencyService.SoftDeleteAsync(transportAgencyId).Result;
            return RedirectToAction("Index");
        }

        [HttpGet]
        public JsonResult Get(long id)
        {
            var model = AgencyService.GetById(id).Result;
            return Json(model);
        }

        public JsonResult GetAllTableData()
        {
            var agencyList = AgencyService.GetAllDataTable();
            return Json(agencyList);
        }
    }
}
