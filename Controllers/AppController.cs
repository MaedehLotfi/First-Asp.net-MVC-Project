using Microsoft.Ajax.Utilities;
using SoulHealth.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Mvc;
using System.Xml.Linq;

namespace SoulHealth.Controllers
{
    public class AppController : ApiController
    {
        ApplicationDbContext mydb = new ApplicationDbContext();


        //https://localhost:44307/api/App/GetPatientList
        //[HttpGet]
        List<Models.Patient> mylistPatient = new List<Models.Patient>();

        public IEnumerable<Models.Patient> GetPatientList()
        {
            mylistPatient = mydb.Patients.ToList();
            return mylistPatient;
        }

        //with id
        List<Models.Patient> myPatient = new List<Models.Patient>();

        public IEnumerable<Models.Patient> GetPatientList(int id)
        {
            myPatient = mydb.Patients.Where(p=>p.id== id).ToList();
            return myPatient;
        }

        List<Models.DiseaseRecord> DiseaseRecords = new List<Models.DiseaseRecord>();

        public IEnumerable<Models.DiseaseRecord> GetDiseaseRecord(int id)
        {
            DiseaseRecords = mydb.DiseaseRecords.Where(p => p.userId == id).ToList();
            return DiseaseRecords;
        }

        List<Models.ASocial> ASocials = new List<Models.ASocial>();

        public IEnumerable<Models.ASocial> GetASocials(int id)
        {
            ASocials = mydb.ASocials.Where(p => p.SId == id).ToList();
            return ASocials;
        }

        List<Models.ASelfManagement> ASelfManagements = new List<Models.ASelfManagement>();
        public IEnumerable<Models.ASelfManagement> GetASelfManagement(int id)
        {
            ASelfManagements = mydb.ASelfManagement.Where(p => p.SId == id).ToList();
            return ASelfManagements;
        }

        List<Models.APhysical> APhysical = new List<Models.APhysical>();
        public IEnumerable<Models.APhysical> GetAPhysical(int id)
        {
            APhysical = mydb.APhysicals.Where(p => p.PhId == id).ToList();
            return APhysical;
        }

        List<Models.MedicationRecord> MedicationRecords = new List<Models.MedicationRecord>();
        public IEnumerable<Models.MedicationRecord> GetMedicationRecord(int id)
        {
            MedicationRecords = mydb.MedicationRecords.Where(p => p.userId == id).ToList();
            return MedicationRecords;
        }

        List<Models.PhysiologicalData> PhysiologicalDatas = new List<Models.PhysiologicalData>();
        public IEnumerable<Models.PhysiologicalData> GetPhysiologicalData(int id)
        {
            PhysiologicalDatas = mydb.PhysiologicalDatas.Where(p => p.PaiId == id).ToList();
            return PhysiologicalDatas;
        }

        List<Models.PatientLimitation> limitations = new List<Models.PatientLimitation>();
        public IEnumerable<Models.PatientLimitation> GetPatientLimitation(int id)
        {
            limitations = mydb.limitations.Where(p => p.PaId == id).ToList();
            return limitations;
        }

        List<Models.ACognition> ACognitions = new List<Models.ACognition>();
        public IEnumerable<Models.ACognition> GetACognitions(int id)
        {
            ACognitions = mydb.ACognitions.Where(p => p.PatientId == id).ToList();
            return ACognitions;
        }

        List<Models.Drug> Drugs = new List<Models.Drug>();
        public IEnumerable<Models.Drug> GetDrugs(int id)
        {
            Drugs = mydb.Drugs.Where(p => p.PId == id).ToList();
            return Drugs;
        }


        //https://localhost:44307/api/App/GetDailyRecordList
        List<Models.DailyRecord> DailyRecordlist = new List<Models.DailyRecord>();
        public IEnumerable<Models.DailyRecord> GetDailyRecordList()
        {
            DailyRecordlist = mydb.DailyRecords.ToList();
            return DailyRecordlist;
        }

        List<Models.DailyRecord> PersonDailyRecordlist = new List<Models.DailyRecord>();
        public IEnumerable<Models.DailyRecord> GetDailyRecordList(int id)
        {
            PersonDailyRecordlist = mydb.DailyRecords.Where(p => p.id == id).ToList();
            return PersonDailyRecordlist;
        }

        [System.Web.Http.HttpPost]
        public void PostRecords (Models.DailyRecord record)
        {
            mydb.DailyRecords.Add(record);
            mydb.SaveChanges();
        }


        //not working!
        [System.Web.Http.HttpPost]
        public void PostDailyRecord ([FromBody]Models.DailyRecord item)
        {
            mydb.DailyRecords.Add(item);
            mydb.SaveChanges();

        }


        // GET api/<controller>
        //public IEnumerable<string> Get()
        //{
        //    return new string[] { "value1", "value2" };
        //}

        // GET api/<controller>/5
        //public string Get(int id)
        //{
        //    return "value";
        //}

        // POST api/<controller>
        //public void Post([FromBody] string value)
        //{
        //}

        // PUT api/<controller>/5
        //public void Put(int id, [FromBody] string value)
        //{
        //}

        // DELETE api/<controller>/5
        //public void Delete(int id)
        //{
        //}
    }
}