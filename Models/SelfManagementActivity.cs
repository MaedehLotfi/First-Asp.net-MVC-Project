using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Xml.Linq;

namespace SoulHealth.Models
{
    public class SelfManagementActivity
    {
        [Key]
        public int id { get; set; }

        [Display(Name = "مصرف دارو بصورت منظم")]
        public bool drug { get; set; }

        [Display(Name = "ثبت علائم و گزارشات")]
        public bool reports { get; set; }

        [Display(Name = "انجام یادآورها")]
        public bool reminders { get; set; }

        [Display(Name = "انجام کارهای روزمره")]
        public bool daily { get; set; }

        [Display(Name = "انجام خرید")]
        public bool shoppong { get; set; }


        [Display(Name = "سایر")]
        public bool other { get; set; }

        [Display(Name = "توضیحات")]
        public string discription { get; set; }

        [Display(Name = "شماره پرونده")]
        public int Pid { get; set; }

        [ForeignKey(nameof(Pid))]
        public Patient Person { get; set; }
    }
}