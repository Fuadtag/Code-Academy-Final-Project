using FinalProject.Data;
using FinalProject.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject.ViewComponents
{
    public class HeaderViewComponent:ViewComponent
    {
        private readonly RentNowContext context;
        public HeaderViewComponent(RentNowContext _context)
        {
            context = _context;
        }
            
        


        public IViewComponentResult Invoke(
            Setting setting
        )
        {
            setting = context.Settings.FirstOrDefault();
            return View(setting);
        }

    }
}
