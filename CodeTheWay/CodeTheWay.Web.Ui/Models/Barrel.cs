﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeTheWay.Web.Ui.Models
{
    public class Barrel
    {

        public Guid Id { get; set; }
        public double Radius { get; set; }
        public double Height { get; set; }
        public String Content { get; set; }
        public String CurrentLocation { get; set; }

    }
}
