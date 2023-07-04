using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace SoulHealth.Models
{
    public class MedicationRecord
    {
        [Key]
        public int id { get; set; }
        [Display(Name = "سابقه بیماری")]
        public string MedicationTitle { get; set; }
        [Display(Name = "توضیحات سابقه بیماری")]
        public string MedicationDescription { get; set; }

        [Display(Name = "شماره پرونده")]
        public int userId { get; set; }

        [ForeignKey(nameof(userId))]
        public Patient Person { get; set; }
    }
}