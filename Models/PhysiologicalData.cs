using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace SoulHealth.Models
{
    public class PhysiologicalData
    {
        [Key]
        public int id { get; set; }
        [Display(Name = "وزن")]
        public string Weight { get; set; }
        [Display(Name = "قد")]
        public string Height { get; set; }
        [Display(Name = "فشار خون")]
        public string bPressure { get; set; }
        [Display(Name = "ضربان قلب")]
        public string hBeat { get; set; }
        [Display(Name = "قند خون")]
        public string bSugar { get; set; }
        [Display(Name = "شماره پرونده")]
        public int PaiId { get; set; }

        [ForeignKey(nameof(PaiId))]
        public Patient Person { get; set; }
    }
}
