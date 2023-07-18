using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Xml.Linq;

namespace SoulHealth.Models
{
    public class Drug
    {
        [Key]
        public int id { get; set; }
        [Required(ErrorMessage = "نام دارو را وارد کنید")]
        [Display(Name = "نام دارو")]
        public string drugName { get; set; }
        [Required(ErrorMessage = "دوز دارو را وارد کنید")]
        [Display(Name = "دوز دارو")]
        public string drugDosage { get; set; }
        [Display(Name = "نام بیماری")]
        public string diseaseName { get; set; }
        [Display(Name = "نحوه مصرف")]
        [Required(ErrorMessage = "نحوه مصرف دارو را وارد کنید")]
        public string usingDescription { get; set; }

        [Display(Name = "شماره پرونده")]
        public int PId { get; set; }

        [ForeignKey(nameof(PId))]
        public Patient Person { get; set; }
    }
}