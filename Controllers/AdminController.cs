using SoulHealth.Migrations;
using SoulHealth.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace SoulHealth.Controllers
{
    public class AdminController : Controller
    {

        ApplicationDbContext mydb = new ApplicationDbContext();

        [Authorize]
        // GET: Admin
        public ActionResult Index()
        {
            return View();
        }
        //dailyRecord
        public ActionResult DailyRecordList(int? searchpoint)
        {
            var result = mydb.DailyRecords.ToList();
            

            if (searchpoint != null && searchpoint != 0)
            {
                result = result.Where(p => p.iid == searchpoint).ToList();
            }
            return View(result);
        }
        public async Task<ActionResult> DeleteReportsByAjax(int id)
        {
            var result = mydb.DailyRecords.Where(p => p.id == id).FirstOrDefault();
            mydb.DailyRecords.Remove(result);
            mydb.SaveChanges();

            return Json(new { msg = "گزارش کاربر با موفقیت حذف شد" });

        }


        //Add+Edit Patient
        public ActionResult Patient(int? id)
        {
            var result = new SoulHealth.Models.Patient();
            if (id != null)
            {
                var row = mydb.Patients.Where(p => p.id == id).FirstOrDefault();
                result = row;
            }
            return View(result);
        }
        [HttpPost]
        public ActionResult Patient(SoulHealth.Models.Patient row)
        {
            if (ModelState.IsValid == true)
            {
                if (row.id != 0)
                {
                    var result = mydb.Patients.Where(p => p.id == row.id).FirstOrDefault();
                    result.userName = row.userName;
                    result.password = row.password;
                    result.FullName = row.FullName;
                    result.NationalCode = row.NationalCode;
                    result.age = row.age;
                    result.gender = row.gender;

                    mydb.SaveChanges();
                    return RedirectToAction("PatientList");
                }
                else
                {
                    mydb.Patients.Add(row);
                    mydb.SaveChanges();
                    return RedirectToAction("PatientList");
                }
            }
            return View(row);
        }
        public ActionResult PatientList(int? searchpoint)
        {
            var result = mydb.Patients.ToList();
            
            if (searchpoint != null && searchpoint != 0)
            {
                result = result.Where(p => p.id == searchpoint).ToList();
            }

            return View(result);
        }

        public async Task<ActionResult> DeletePatientByAjax(int id)
        {
            var result = mydb.Patients.Where(p => p.id == id).FirstOrDefault();
            mydb.Patients.Remove(result);
            mydb.SaveChanges();

            return Json(new { msg = "کاربر با موفقیت حذف شد" });

        }


        //Add+Edit Drug
        public ActionResult Drug(int? id)
        {
            var result = new SoulHealth.Models.Drug();
            if (id != null)
            {
                var row = mydb.Drugs.Where(p => p.id == id).FirstOrDefault();
                result = row;
            }
            return View(result);
        }

        [HttpPost]
        public ActionResult Drug(SoulHealth.Models.Drug row)
        {
            if (ModelState.IsValid == true)
            {
                if (row.id != 0)
                {
                    var result = mydb.Drugs.Where(p => p.id == row.id).FirstOrDefault();
                    result.drugName = row.drugName;
                    result.drugDosage = row.drugDosage;
                    result.diseaseName = row.diseaseName;
                    result.usingDescription = row.usingDescription;
                    result.PId = row.PId;

                    mydb.SaveChanges();
                    return RedirectToAction("DrugList");
                }
                else
                {
                    mydb.Drugs.Add(row);
                    mydb.SaveChanges();
                    return RedirectToAction("DrugList");
                }

            }
            return View(row);
        }
        public ActionResult DrugList(int? searchpoint)
        {
            var result = mydb.Drugs.ToList();


            if (searchpoint != null && searchpoint != 0)
            {
                result = result.Where(p => p.PId == searchpoint).ToList();
            }
            return View(result);
        }

        public async Task<ActionResult> DeleteDrugByAjax(int id)
        {
            var result = mydb.Drugs.Where(p => p.id == id).FirstOrDefault();
            mydb.Drugs.Remove(result);
            mydb.SaveChanges();

            return Json(new { msg = "دارو کاربر با موفقیت حذف شد" });

        }

        //ACognition 
        public ActionResult ACognition(int? id)
        {
            var result = new SoulHealth.Models.ACognition();
            if (id != null)
            {
                var row = mydb.ACognitions.Where(p => p.id == id).FirstOrDefault();
                result = row;
            }
            return View(result);
        }

        [HttpPost]
        public ActionResult ACognition(SoulHealth.Models.ACognition row)
        {
            if (ModelState.IsValid == true)
            {
                if (row.id != 0)
                {
                    var result = mydb.ACognitions.Where(p => p.id == row.id).FirstOrDefault();
                    result.Level1 = row.Level1;
                    result.Level2 = row.Level2;
                    result.Level3 = row.Level3;
                    result.Level4 = row.Level4;
                    result.SocialDescription = row.SocialDescription;
                    result.PatientId = row.PatientId;

                    mydb.SaveChanges();
                    return RedirectToAction("ACognitionList");
                }
                else
                {
                    mydb.ACognitions.Add(row);
                    mydb.SaveChanges();
                    return RedirectToAction("ACognitionList");
                }
            }
            return View(row);
        }
        public ActionResult ACognitionList(int? searchpoint)
        {
            var result = mydb.ACognitions.ToList();
            if (searchpoint != null && searchpoint != 0)
            {
                result = result.Where(p => p.PatientId == searchpoint).ToList();
            }
            return View(result);
        }

        public async Task<ActionResult> DeleteACognitionByAjax(int id)
        {
            var result = mydb.ACognitions.Where(p => p.id == id).FirstOrDefault();
            mydb.ACognitions.Remove(result);
            mydb.SaveChanges();

            return Json(new { msg = "فعالیت شناختی کاربر با موفقیت حذف شد" });

        }


        //ASocial
        public ActionResult ASocial(int? id)
        {
            var result = new SoulHealth.Models.ASocial();
            if (id != null)
            {
                var row = mydb.ASocials.Where(p => p.id == id).FirstOrDefault();
                result = row;
            }
            return View(result);
        }

        [HttpPost]
        public ActionResult ASocial(SoulHealth.Models.ASocial row)
        {
            if (ModelState.IsValid == true)
            {
                if (row.id != 0)
                {
                    var result = mydb.ASocials.Where(p => p.id == row.id).FirstOrDefault();
                    result.Level1 = row.Level1;
                    result.Level2 = row.Level2;
                    result.Level3 = row.Level3;
                    result.Level4 = row.Level4;
                    result.SocialDescription = row.SocialDescription;
                    result.SId = row.SId;

                    mydb.SaveChanges();
                    return RedirectToAction("ASocialList");
                }
                else
                {
                    mydb.ASocials.Add(row);
                    mydb.SaveChanges();
                    return RedirectToAction("ASocialList");
                }
            }
            return View(row);
        }
        public ActionResult ASocialList(int? searchpoint)
        {
            var result = mydb.ASocials.ToList();
            if (searchpoint != null && searchpoint != 0)
            {
                result = result.Where(p => p.SId == searchpoint).ToList();
            }
            return View(result);
        }

        public async Task<ActionResult> DeleteASocialByAjax(int id)
        {
            var result = mydb.ASocials.Where(p => p.id == id).FirstOrDefault();
            mydb.ASocials.Remove(result);
            mydb.SaveChanges();

            return Json(new { msg = "فعالیت اجتماعی کاربر با موفقیت حذف شد" });

        }


        //APhysical
        public ActionResult APhysical(int? id)
        {
            var result = new SoulHealth.Models.APhysical();
            if (id != null)
            {
                var row = mydb.APhysicals.Where(p => p.id == id).FirstOrDefault();
                result = row;
            }
            return View(result);
        }

        [HttpPost]
        public ActionResult APhysical(SoulHealth.Models.APhysical row)
        {
            if (ModelState.IsValid == true)
            {
                if (row.id != 0)
                {
                    var result = mydb.APhysicals.Where(p => p.id == row.id).FirstOrDefault();
                    result.Level1 = row.Level1;
                    result.Level2 = row.Level2;
                    result.Level3 = row.Level3;
                    result.Level4 = row.Level4;
                    result.PhysicalDescription = row.PhysicalDescription;
                    result.PhId = row.PhId;

                    mydb.SaveChanges();
                    return RedirectToAction("APhysicalList");
                }
                else
                {
                    mydb.APhysicals.Add(row);
                    mydb.SaveChanges();
                    return RedirectToAction("APhysicalList");
                }
            }
            return View(row);
        }
        public ActionResult APhysicalList(int? searchpoint)
        {
            var result = mydb.APhysicals.ToList();
            if (searchpoint != null && searchpoint != 0)
            {
                result = result.Where(p => p.PhId == searchpoint).ToList();
            }
            return View(result);
        }

        public async Task<ActionResult> DeleteAPhysicalByAjax(int id)
        {
            var result = mydb.APhysicals.Where(p => p.id == id).FirstOrDefault();
            mydb.APhysicals.Remove(result);
            mydb.SaveChanges();

            return Json(new { msg = "فعالیت فیزیکی کاربر با موفقیت حذف شد" });

        }

        //ASelfManagement
        public ActionResult ASelfManagement(int? id)
        {
            var result = new SoulHealth.Models.ASelfManagement();
            if (id != null)
            {
                var row = mydb.ASelfManagement.Where(p => p.id == id).FirstOrDefault();
                result = row;
            }
            return View(result);
        }

        [HttpPost]
        public ActionResult ASelfManagement(SoulHealth.Models.ASelfManagement row)
        {
            if (ModelState.IsValid == true)
            {
                if (row.id != 0)
                {
                    var result = mydb.ASelfManagement.Where(p => p.id == row.id).FirstOrDefault();
                    result.Level1 = row.Level1;
                    result.Level2 = row.Level2;
                    result.Level3 = row.Level3;
                    result.Level4 = row.Level4;
                    result.SelfManagementDescription = row.SelfManagementDescription;
                    result.SId = row.SId;

                    mydb.SaveChanges();
                    return RedirectToAction("ASelfManagementList");
                }
                else
                {
                    mydb.ASelfManagement.Add(row);
                    mydb.SaveChanges();
                    return RedirectToAction("ASelfManagementList");
                }
            }
            return View(row);
        }
        public ActionResult ASelfManagementList(int? searchpoint)
        {
            var result = mydb.ASelfManagement.ToList();
            if (searchpoint != null && searchpoint != 0)
            {
                result = result.Where(p => p.SId == searchpoint).ToList();
            }
            return View(result);
        }

        public async Task<ActionResult> DeleteASelfManagementlByAjax(int id)
        {
            var result = mydb.ASelfManagement.Where(p => p.id == id).FirstOrDefault();
            mydb.ASelfManagement.Remove(result);
            mydb.SaveChanges();

            return Json(new { msg = "فعالیت خود مدیریتی کاربر با موفقیت حذف شد" });

        }


        //Limitations
        public ActionResult PatientLimitation(int? id)
        {
            var result = new SoulHealth.Models.PatientLimitation();
            if (id != null)
            {
                var row = mydb.limitations.Where(p => p.id == id).FirstOrDefault();
                result = row;
            }
            return View(result);
        }

        [HttpPost]
        public ActionResult PatientLimitation(SoulHealth.Models.PatientLimitation row)
        {
            if (ModelState.IsValid == true)
            {
                if (row.id != 0)
                {
                    var result = mydb.limitations.Where(p => p.id == row.id).FirstOrDefault();
                    result.movementRestriction = row.movementRestriction;
                    result.physicalRestriction = row.physicalRestriction;
                    result.foodRestriction = row.foodRestriction;
                    result.otherRestriction = row.otherRestriction;
                    result.limitationDescription = row.limitationDescription;
                    result.PaId = row.PaId;

                    mydb.SaveChanges();
                    return RedirectToAction("PLimitationList");
                }
                else
                {
                    mydb.limitations.Add(row);
                    mydb.SaveChanges();
                    return RedirectToAction("PLimitationList");
                }
            }
            return View(row);
        }
        public ActionResult PLimitationList(int? searchpoint)
        {
            var result = mydb.limitations.ToList();
            if (searchpoint != null && searchpoint != 0)
            {
                result = result.Where(p => p.PaId == searchpoint).ToList();
            }
            return View(result);
        }

        public async Task<ActionResult> DeleteLimitationByAjax(int id)
        {
            var result = mydb.limitations.Where(p => p.id == id).FirstOrDefault();
            mydb.limitations.Remove(result);
            mydb.SaveChanges();

            return Json(new { msg = "محدودیت کاربر با موفقیت حذف شد" });

        }

        //PhysiologicalData
        public ActionResult PhysiologicalData(int? id)
        {
            var result = new SoulHealth.Models.PhysiologicalData();
            if (id != null)
            {
                var row = mydb.PhysiologicalDatas.Where(p => p.id == id).FirstOrDefault();
                result = row;
            }
            return View(result);
        }

        [HttpPost]
        public ActionResult PhysiologicalData(SoulHealth.Models.PhysiologicalData row)
        {
            if (ModelState.IsValid == true)
            {
                if (row.id != 0)
                {
                    var result = mydb.PhysiologicalDatas.Where(p => p.id == row.id).FirstOrDefault();
                    result.Weight = row.Weight;
                    result.Height = row.Height;
                    result.bPressure = row.bPressure;
                    result.hBeat = row.hBeat;
                    result.bSugar = row.bSugar;
                    result.PaiId = row.PaiId;

                    mydb.SaveChanges();
                    return RedirectToAction("PhyDataList");
                }
                else
                {
                    mydb.PhysiologicalDatas.Add(row);
                    mydb.SaveChanges();
                    return RedirectToAction("PhyDataList");
                }
            }
            return View(row);
        }
        public ActionResult PhyDataList(int? searchpoint)
        {
            var result = mydb.PhysiologicalDatas.ToList();
            if (searchpoint != null && searchpoint != 0)
            {
                result = result.Where(p => p.PaiId == searchpoint).ToList();
            }
            return View(result);
        }

        public async Task<ActionResult> DeletePhyDataByAjax(int id)
        {
            var result = mydb.PhysiologicalDatas.Where(p => p.id == id).FirstOrDefault();
            mydb.PhysiologicalDatas.Remove(result);
            mydb.SaveChanges();

            return Json(new { msg = "اطلاعات فیزیولوژیکی کاربر با موفقیت حذف شد" });

        }

        //MedicationRecord
        public ActionResult MedicationRecord(int? id)
        {
            var result = new SoulHealth.Models.MedicationRecord();
            if (id != null)
            {
                var row = mydb.MedicationRecords.Where(p => p.id == id).FirstOrDefault();
                result = row;
            }
            return View(result);
        }

        [HttpPost]
        public ActionResult MedicationRecord(SoulHealth.Models.MedicationRecord row)
        {
            if (ModelState.IsValid == true)
            {
                if (row.id != 0)
                {
                    var result = mydb.MedicationRecords.Where(p => p.id == row.id).FirstOrDefault();
                    result.MedicationTitle = row.MedicationTitle;
                    result.MedicationDescription = row.MedicationDescription;
                    result.userId = row.userId;

                    mydb.SaveChanges();
                    return RedirectToAction("MedRecordsList");
                }
                else
                {
                    mydb.MedicationRecords.Add(row);
                    mydb.SaveChanges();
                    return RedirectToAction("MedRecordsList");
                }
            }
            return View(row);
        }
        public ActionResult MedRecordsList(int? searchpoint)
        {
            var result = mydb.MedicationRecords.ToList();
            if (searchpoint != null && searchpoint != 0)
            {
                result = result.Where(p => p.userId == searchpoint).ToList();
            }
            return View(result);
        }

        public async Task<ActionResult> DeleteMedRecordsByAjax(int id)
        {
            var result = mydb.MedicationRecords.Where(p => p.id == id).FirstOrDefault();
            mydb.MedicationRecords.Remove(result);
            mydb.SaveChanges();

            return Json(new { msg = "سابقه بیماری کاربر با موفقیت حذف شد" });

        }

        //DiseaseRecords
        public ActionResult PatientDiseaseRecords(int? id)
        {
            var result = new SoulHealth.Models.DiseaseRecord();
            if (id != null)
            {
                var row = mydb.DiseaseRecords.Where(p => p.id == id).FirstOrDefault();
                result = row;
            }
            return View(result);
        }

        [HttpPost]
        public ActionResult PatientDiseaseRecords(SoulHealth.Models.DiseaseRecord row)
        {
            if (ModelState.IsValid == true)
            {
                if (row.id != 0)
                {
                    var result = mydb.DiseaseRecords.Where(p => p.id == row.id).FirstOrDefault();
                    result.DiseaseTitle = row.DiseaseTitle;
                    result.DiseaseDescription = row.DiseaseDescription;
                    result.userId = row.userId;

                    mydb.SaveChanges();
                    return RedirectToAction("DiseaseRecords");
                }
                else
                {
                    mydb.DiseaseRecords.Add(row);
                    mydb.SaveChanges();
                    return RedirectToAction("DiseaseRecords");
                }
            }
            return View(row);
        }
        public ActionResult DiseaseRecords(int? searchpoint)
        {
            var result = mydb.DiseaseRecords.ToList();
            if (searchpoint != null && searchpoint != 0)
            {
                result = result.Where(p => p.userId == searchpoint).ToList();
            }
            return View(result);
        }

        public async Task<ActionResult> DeleteDiseaseRecordsByAjax(int id)
        {
            var result = mydb.DiseaseRecords.Where(p => p.id == id).FirstOrDefault();
            mydb.DiseaseRecords.Remove(result);
            mydb.SaveChanges();

            return Json(new { msg = "سابقه بیماری کاربر با موفقیت حذف شد" });

        }


        // GET: Admin/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Admin/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Admin/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Admin/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Admin/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Admin/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Admin/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
