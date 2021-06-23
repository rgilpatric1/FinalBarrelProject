using CodeTheWay.Web.Ui.Models;
using CodeTheWay.Web.Ui.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CodeTheWay.Web.Ui.Models.ViewModels;
namespace CodeTheWay.Web.Ui.Controllers
{
    public class BarrelController : Controller
    {
        private IBarrelService BarrelService;

        public BarrelController(IBarrelService barrelService)
        {
            this.BarrelService = barrelService;
        }
        public async Task<IActionResult> Index()
        {
            return View(await BarrelService.GetBarrels());
        }

        public async Task<IActionResult> Create()
        {
            return View(new BarrelRegistrationViewModel());
        }
        [HttpPost]
        public async Task<IActionResult> Register(BarrelRegistrationViewModel model)
        {
            if (ModelState.IsValid)
            {
                if (model.Radius > 0 && model.Height > 0)
                {
                    Barrel barrel = new Barrel()
                    {
                        Id = model.Id,
                        Radius = model.Radius,
                        Height = model.Height,
                        Content = model.Content,
                        CurrentLocation = model.CurrentLocation
                    };
                    var abc = await BarrelService.Create(barrel);
                }
                return RedirectToAction("Index");
            }
            return View(model);
        }
    }
}