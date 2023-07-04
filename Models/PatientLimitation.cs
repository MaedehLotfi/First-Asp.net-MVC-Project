using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Xml.Linq;

namespace SoulHealth.Models
{
    public class PatientLimitation
    {
        [Key]
        public int id { get; set; }
        [Display(Name = "محدودیت حرکتی")]
        public bool movementRestriction { get; set; }
        [Display(Name = "محدودیت جسمی")]
        public bool physicalRestriction { get; set; }

        [Display(Name = "محدودیت غذایی")]
        public bool foodRestriction { get; set; }

        [Display(Name = "سایر محدودیت ها")]
        public bool otherRestriction { get; set; }

        [Display(Name = "توضیحات")]
        public string limitationDescription { get; set; }
        [Display(Name = "شماره پرونده")]
        public int PaId { get; set; }

        [ForeignKey(nameof(PaId))]
        public Patient Person { get; set; }
    }
}