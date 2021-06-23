﻿using CodeTheWay.Web.Ui.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeTheWay.Web.Ui.Services
{
    interface IBarrelService
    {
        public  Task<List<Barrel>> GetBarrels();
        public Task<Barrel> GetBarrel(Guid id);
    }
}
