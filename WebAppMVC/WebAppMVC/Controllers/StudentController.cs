using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebAppMVC.Models;

namespace WebAppMVC.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Display()
        {
            List<Students> slist = new List<Students>()
            {
                new Students{SID=1,SName="Shashank",SDOB=new DateTime(day:12,month:09,year:2008),SContact="787896844"},
                new Students{SID=2,SName="Madhav",SDOB=new DateTime(day:11,month:02,year:2007),SContact="7414412732"},
                new Students{SID=3,SName="Zarina",SDOB=new DateTime(day:01,month:04,year:2012),SContact="9858745147"},
                new Students{SID=4,SName="Rahim",SDOB=new DateTime(day:07,month:07,year:2014),SContact="9696857568"},
                new Students{SID=5,SName="Menakshi",SDOB=new DateTime(day:02,month:08,year:2011),SContact="7896968123"},
            };
            int c = slist.Count();
            ViewBag.Total = c;
            return View(slist);
           
        }
    }
}
