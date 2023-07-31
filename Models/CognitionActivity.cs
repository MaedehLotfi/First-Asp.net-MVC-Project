using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Xml.Linq;

namespace SoulHealth.Models
{
    public class CognitionActivity
    {
        [Key]
        public int id { get; set; }

        [Display(Name = "خواندن کتاب، مجله، روزنامه")]
        public bool reading { get; set; }

        [Display(Name = "پیگیری اخبار در شبکه های اجتماعی")]
        public bool watching { get; set; }

        [Display(Name = "حل جدول")]
        public bool quiz { get; set; }

        [Display(Name = "انجام بازی")]
        public bool game { get; set; }


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