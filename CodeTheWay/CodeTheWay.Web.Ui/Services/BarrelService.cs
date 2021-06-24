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
       public IBarrelRepository BarrelRepository;
        public BarrelService(AppDbContext dbContext)
        {
            this.BarrelRepository = new BarrelRepository(dbContext);
        }
        public async Task<List<Barrel>> GetBarrels()
        {
            return await this.BarrelRepository.GetBarrels();
        }

        public async Task<Barrel> GetBarrel(Guid id)
        {
            return await this.BarrelRepository.GetBarrel(id);
        }

        public async Task<Barrel> Create(Barrel barrel)
        {
            return await this.BarrelRepository.Create(barrel);
        }
        public async Task<Barrel> Update(Barrel barrel)
        {
            return await this.BarrelRepository.Update(barrel);
        }
        public async Task<Barrel> Delete(Barrel barrel)
        {
            return await BarrelRepository.Delete(barrel);
        }
    }
}
