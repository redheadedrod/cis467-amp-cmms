using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;
using CIS467_AMP.Models.Shared;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace CIS467_AMP.Models
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit http://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
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
        // Shared databases - Must be done in this order due to dependencies
        public DbSet<Manufacturer> Manufacturers { get; set; }
        public DbSet<Map> Maps { get; set; }
        public DbSet<WorkGroup> WorkGroups { get; set; }
        public DbSet<ManufacturerContact> ManufacturerContacts { get; set; }
        public DbSet<Part> Parts { get; set; }
        public DbSet<Worker> Workers { get; set; }
        public DbSet<AssetType> AssetTypes { get; set; }
        public DbSet<PartsListIndex> PartsListIndices { get; set; }
        public DbSet<WorkGroupSupervisor> WorkGroupSupervisors { get; set; }
        public DbSet<Variant> Variants { get; set; }
        public DbSet<AssetInventory> AssetInventories { get; set; }
        public DbSet<JobPlan> JobPlans { get; set; }
        public DbSet<JobPlanDocument> JobPlanDocuments { get; set; }
        public DbSet<JobPlanPart> JobPlanParts { get; set; }
        /*public DbSet<> Type { get; set; }
        public DbSet<> Type { get; set; }
        public DbSet<> Type { get; set; }*/
        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
    }
}