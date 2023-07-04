using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace SoulHealth.Models
{
    public class DailyRecord
    {
        [Key]
        public int id { get; set; }

        [Display(Name = "دارو صبح")]
        public bool morningDrug { get; set; }
        [Display(Name = "دارو عصر")]
        public bool eveningDrug { get; set; }
        [Display(Name = "دارو شب")]
        public bool nightDrug { get; set; }


        [Display(Name = "فعالیت شناختی")]
        public bool ACognition { get; set; }
        [Display(Name = "فعالیت فیزیکی")]
        public bool APhysical { get; set; }
        [Display(Name = "فعالیت اجتماعی")]
        public bool ASocial { get; set; }
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
        public int iid { get; set; }

        [ForeignKey(nameof(iid))]
        public virtual Patient Patients { get; set; }
    }
}