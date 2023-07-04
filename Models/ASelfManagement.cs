using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Xml.Linq;

namespace SoulHealth.Models
{
    public class ASelfManagement
    {
        [Key]
        public int id { get; set; }
        [Display(Name = "سطح یک")]
        public bool Level1 { get; set; }
        [Display(Name = "سطح دو")]
        public bool Level2 { get; set; }
        [Display(Name = "سطح سه")]
        public bool Level3 { get; set; }
        [Display(Name = "سطح چهار")]
        public bool Level4 { get; set; }
        [Display(Name = "توضیحات")]
        public string SelfManagementDescription { get; set; }


        [Display(Name = "شماره پرونده")]
        public int SId { get; set; }

        [ForeignKey(nameof(SId))]
        public Patient Person { get; set; }
    }
}