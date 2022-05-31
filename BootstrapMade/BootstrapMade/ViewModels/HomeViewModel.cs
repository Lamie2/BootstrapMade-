using BootstrapMade.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BootstrapMade.ViewModels
{
    public class HomeViewModel
    {
        public List<Service> Services { get; set; }
        public List<Feature> Features { get; set; }
    }
}
