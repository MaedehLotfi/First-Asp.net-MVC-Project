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


        //https://localhost:44307/api/App/GetDailyRecordList
        List<Models.DailyRecord> DailyRecordlist = new List<Models.DailyRecord>();
        public IEnumerable<Models.DailyRecord> GetDailyRecordList()
        {
            DailyRecordlist = mydb.DailyRecords.ToList();
            return DailyRecordlist;
        }



        //List<Models.ACognition> mylist = new List<Models.ACognition>();

        //public IEnumerable<Models.ACognition> GetACognitions()
        //{
        //    mylist = mydb.ACognitions.ToList();
        //    return mylist;
        //}


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