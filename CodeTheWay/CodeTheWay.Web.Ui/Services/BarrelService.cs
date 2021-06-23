using CodeTheWay.Web.Ui.Models;
using CodeTheWay.Web.Ui.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeTheWay.Web.Ui.Services
{
    public class BarrelService : IBarrelService
    {
        IBarrelRepository BarrelRepository;
        public async Task<List<Barrel>> GetBarrels()
        {
            return await this.BarrelRepository.GetBarrels();
        }

        public async Task<Barrel> GetBarrel(Guid id)
        {
            return await this.BarrelRepository.GetBarrel(id);
        }
    }
}
