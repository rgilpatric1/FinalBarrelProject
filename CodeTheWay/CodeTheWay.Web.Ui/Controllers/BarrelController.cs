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

        public async Task<IActionResult> Details(Guid id)
        {
            var barrel = await BarrelService.GetBarrel(id);
            BarrelRegistrationViewModel test = new BarrelRegistrationViewModel()
            {
                Id = barrel.Id,
                Radius = barrel.Radius,
                Height = barrel.Height,
                Content = barrel.Content,
                CurrentLocation = barrel.CurrentLocation

            };
            return View(test);
        }
    }
}