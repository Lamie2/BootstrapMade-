using BootstrapMade.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BootstrapMade.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            List<Service> Services = new List<Service>
            {
                new Service
                {
                    Id=1,
                    Icon="bx bxl-dribbble",
                    Title="Lorem Ipsum",
                    Description="Voluptatum deleniti atque corrupti quos dolores et quas molestias excepturi"
                },
                 new Service
                {
                    Id=2,
                    Icon="bx bx-file",
                    Title="Sed ut perspiciatis",
                    Description="Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore"
                },
                  new Service
                {
                    Id=3,
                    Icon= "bx bx-tachometer",
                    Title= "Magni Dolores",
                    Description="Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia"
                },
                   new Service
                {
                    Id=4,
                    Icon="bx bx-world",
                    Title="Nemo Enim",
                    Description="At vero eos et accusamus et iusto odio dignissimos ducimus qui blanditiis"
                },
                new Service
                {
                    Id=5,
                    Icon="bx bx-arch",
                    Title="Divera don",
                    Description="Modi nostrum vel laborum. Porro fugit error sit minus sapiente sit aspernatur"
                },
                new Service
                {
                    Id=6,
                    Icon="bx bx-slideshow",
                    Title="Dele cardo",
                    Description="Quis consequatur saepe eligendi voluptatem consequatur dolor consequuntur"
                }

            };

            List<Feature> Features = new List<Feature>
          {
                new Feature
                {
                    Id = 1,
                    Icon = "bi bi-card-checklist",
                    Title = "Lorem Ipsum",
                    Description = "Voluptatum deleniti atque corrupti quos dolores et quas molestias excepturi sint occaecati cupiditate non provident"
                },
                new Feature
                {
                    Id = 2,
                    Icon = "bi bi-bar-chart",
                    Title = "Dolor Sitema",
                    Description = "Minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat tarad limino ata"
                },
                new Feature
                {
                    Id = 3,
                    Icon = "bi bi-binoculars",
                    Title = "Sed ut perspiciatis",
                    Description = "Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur"
                }
          };


            return View();
        }
    }
}
