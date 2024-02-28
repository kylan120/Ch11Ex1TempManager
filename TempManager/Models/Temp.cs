using Microsoft.AspNetCore.Components.Web;
using System;
using System.ComponentModel.DataAnnotations;

namespace TempManager.Models
{
    public class Temp
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Please enter a valid date")]
        public DateTime? Date { get; set; }
       
        [Range (-200, 200)]
        public double? Low { get; set; }
        
        [Range(-200, 200)]
        public double? High { get; set; }
    }
}
