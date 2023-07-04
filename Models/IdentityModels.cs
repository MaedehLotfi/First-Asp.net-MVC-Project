using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace SoulHealth.Models
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit https://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class ApplicationUser : IdentityUser
    {
        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Add custom user claims here
            return userIdentity;
        }
    }

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }
        public DbSet<Patient> Patients { get; set; }
        
public DbSet<Drug> Drugs { get; set; }
        public DbSet<ACognition> ACognitions { get; set; }
        public DbSet<PatientLimitation> limitations { get; set; }
        public DbSet<PhysiologicalData> PhysiologicalDatas { get; set; }
        public DbSet<MedicationRecord> MedicationRecords { get; set; }
        public DbSet<APhysical> APhysicals { get; set; }
        public DbSet<ASelfManagement> ASelfManagement { get; set; }
        public DbSet<ASocial> ASocials { get; set; }
        public DbSet<DailyRecord> DailyRecords { get; set; }



        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
    }
}