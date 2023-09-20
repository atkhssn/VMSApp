using Autofac;
using Microsoft.AspNetCore.Mvc;
using VMS.Infrastructure.Model;
using VMS.Infrastructure.Service;

namespace VMS.App.Controllers
{
    public class MerchantController : Controller
    {
        public readonly MerchantService merchantSevice;
        public ILifetimeScope scope { get; set; }

        public MerchantController(MerchantService merchantSevice, ILifetimeScope lifetimeScope)
        {
            this.merchantSevice = merchantSevice;
            this.scope = lifetimeScope;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var data = new MerchantModel()
            {
                MerchantList = merchantSevice.Get()
            };
            return View(data);
        }

        [HttpPost]
        public IActionResult Add(MerchantModel modelRequest)
        {
            bool isCreate = merchantSevice.Add(modelRequest);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Edit(long id)
        {
             var model = merchantSevice.GetMerchant(id);
            return View(model);
        }

        [HttpPost]
        public IActionResult Update(MerchantModel modelRequest)
        {
            bool isUpdate = merchantSevice.UpdateMerchant(modelRequest);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Delete(MerchantModel modelRequest)
        {
            bool isDelete = merchantSevice.DeleteMerchant(modelRequest);
            return RedirectToAction("Index");
        }
    }
}
