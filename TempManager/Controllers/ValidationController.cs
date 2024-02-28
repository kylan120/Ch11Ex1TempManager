using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using TempManager.Models;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace TempManager.Controllers
{
    public class ValidationController : Controller
    {
        private TempManagerContext context { get; set; }
        public ValidationController(TempManagerContext ctx) => context = ctx;

        public JsonResult CheckDate(string date)
        {
            DateTime dt = DateTime.Parse(date);
            Temp temp = context.Temps.FirstOrDefault(t => t.Date == dt);

            if (temp == null)
                return Json(true);
            else
                return Json("Error");

        }

        
    }
}
