using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Xml.Linq;

namespace SoulHealth.Models
{
    public class Patient
    {
        [Key]
        public int id { get; set; }
        [Required(ErrorMessage = "نام کاربری را وارد کنید")]
        [Display(Name = "نام کاربری")]
        public string userName { get; set; }
        [Required(ErrorMessage = "رمز عبور را وارد کنید")]
        [Display(Name = "رمز عبور")]
        public string password { get; set; }
        [Required(ErrorMessage = "نام و نام خانوادگی را وارد کنید")]
        [Display(Name = "نام و نام خانوادگی")]
        public string FullName { get; set; }
        [Display(Name = "کدملی")]
        public string NationalCode { get; set; }
        [Display(Name = "سن")]
        public int age { get; set; }
        [Display(Name = "جنسیت")]
        public string gender { get; set; }

        public virtual ICollection<Drug> PatientDrugs { get; set; }
        public virtual ICollection<ACognition> PatientACognition { get; set; }
        public virtual ICollection<PatientLimitation> Patientlimits { get; set; }
        public virtual ICollection<PhysiologicalData> PhysiologicalDatas { get; set; }
        public virtual ICollection<MedicationRecord> MedicationRecords { get; set; }
        public virtual ICollection<APhysical> APhysicals { get; set; }
        public virtual ICollection<ASelfManagement> ASelfManagement { get; set; }
        public virtual ICollection<ASocial> ASocials { get; set; }
        public virtual ICollection<DailyRecord> DailyRecords { get; set; }
        public virtual ICollection<DiseaseRecord> DiseaseRecords { get; set; }



    }
}