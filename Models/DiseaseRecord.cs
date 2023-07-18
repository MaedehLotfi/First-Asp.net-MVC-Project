using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Xml.Linq;

namespace SoulHealth.Models
{
    public class DiseaseRecord
    {
        [Key]
        public int id { get; set; }
        [Display(Name = "سابقه بیماری")]
        public string DiseaseTitle { get; set; }
        [Display(Name = "توضیحات سابقه بیماری")]
        public string DiseaseDescription { get; set; }

        [Display(Name = "شماره پرونده")]
        public int userId { get; set; }

        [ForeignKey(nameof(userId))]
        public Patient Person { get; set; }
    }
}