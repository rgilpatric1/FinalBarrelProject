using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeTheWay.Web.Ui.Models.ViewModels
{
    public class BarrelRegistrationViewModel
    {
        public Guid Id { get; set; }
        public double Radius { get; set; }
        public double Height { get; set; }
        public String Content { get; set; }
        public String CurrentLocation { get; set; }

    }
}
