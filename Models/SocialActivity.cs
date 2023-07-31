using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace SoulHealth.Models
{
    public class SocialActivity
    {
        [Key]
        public int id { get; set; }

        [Display(Name = "پیاده روی با دوستان")]
        public bool Walking { get; set; }

        [Display(Name = "مهمانی و دورهمی")]
        public bool party { get; set; }

        [Display(Name = "پیک نیک رفتن")]
        public bool picnic { get; set; }
        [Display(Name = "گردش در بیرون شهر")]
        public bool outsideCity { get; set; }
        [Display(Name = "تفریحات دسته جمعی")]
        public bool groupActivity { get; set; }
        [Display(Name = "انجام فعالیتهای معنوی به جماعت")]
        public bool helping { get; set; }

        [Display(Name = "شرکت در مراسم های مذهبی")]
        public bool pray { get; set; }

        [Display(Name = "انجام کارهای هنری")]
        public bool art { get; set; }

        [Display(Name = "مسافرت")]
        public bool travel { get; set; }

        [Display(Name = "ارتباطات خانوادگی")]
        public bool family { get; set; }
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