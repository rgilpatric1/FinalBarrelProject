    using CodeTheWay.Web.Ui.Models;
using CodeTheWay.Web.Ui.Models.ViewModels;
using CodeTheWay.Web.Ui.Services; //CHECK
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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

        public async Task<IActionResult> Delete(Guid id)
        {
            var barrel = await BarrelService.GetBarrel(id);
            await BarrelService.Delete(barrel);
            return RedirectToAction("Index");
        }
    }
}