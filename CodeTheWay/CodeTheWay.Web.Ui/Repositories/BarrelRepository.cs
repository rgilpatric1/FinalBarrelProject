using CodeTheWay.Web.Ui.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeTheWay.Web.Ui.Repositories
{
    public class BarrelRepository : IBarrelRepository
    {
        private AppDbContext AppDbContext;
        public async Task<List<Barrel>> GetBarrels()
        {
            return await AppDbContext.Barrel.ToListAsync();
        }

        public async Task<Barrel> GetBarrel(Guid id)
        {
            return await AppDbContext.Barrel.FirstOrDefaultAsync(i => i.Id == id);
        }
    }
}
