using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;
using CIS467_AMP.Models.Logbook;
using CIS467_AMP.Models.Maintenance;
using CIS467_AMP.Models.Shared;
using CIS467_AMP.Models.StockRoom;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using MaintenanceStatus = CIS467_AMP.Models.Maintenance.MaintenanceStatus;
using MaintenanceType = CIS467_AMP.Models.Maintenance.MaintenanceType;

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
        // Databases are in order of dependencies. Initial model migrations take this into account
        // Shared databases - Must be done in this order due to dependencies
        public DbSet<Manufacturer> Manufacturers { get; set; }
        public DbSet<Map> Maps { get; set; }
        public DbSet<WorkGroup> WorkGroups { get; set; }
        public DbSet<ManufacturerContact> ManufacturerContacts { get; set; }
        public DbSet<PartType> PartTypes { get; set; } 
        public DbSet<Part> Parts { get; set; }
        public DbSet<Worker> Workers { get; set; }
        public DbSet<AssetType> AssetTypes { get; set; }
        public DbSet<Variant> Variants { get; set; }
        public DbSet<WorkGroupSupervisor> WorkGroupSupervisors { get; set; }
        public DbSet<PartsListIndex> PartsListIndices { get; set; }
        public DbSet<AssetInventory> AssetInventories { get; set; }
        public DbSet<JobPlan> JobPlans { get; set; }
        public DbSet<JobPlanDocument> JobPlanDocuments { get; set; }
        public DbSet<JobPlanPart> JobPlanParts { get; set; }
        //Maintenance databases
        public DbSet<ClassOfIssue> MaintenanceClassOfIssues { get; set; }
        public DbSet<Issue> MaintenanceIssues { get; set; }
        public DbSet<MaintenanceStatus> MaintenanceStatuses { get; set; }
        public DbSet<MaintenanceType> MaintenanceTypes { get; set; }
        public DbSet<IssueIndex> IssueIndexes { get; set; }
        public DbSet<WorkOrder> MaintenanceWorkOrders { get; set; }
        public DbSet<PartIndex> MaintenancePartIndices { get; set; }
        public DbSet<WorkTime> MaintenanceWorkTimes { get; set; }
        //stockroom databases
        public DbSet<OrderStatus> StockroomOrderStatuses { get; set; }
        public DbSet<StockroomRequestStatus> StockroomRequestStatuses { get; set; }
        public DbSet<Supplier> StockroomSuppliers { get; set; }
        public DbSet<Request> StockroomRequests { get; set; }
        public DbSet<StockroomInventory> StockroomInventories { get; set; }
        public DbSet<SupplierContact> StockroomSupplierContacts { get; set; }
        public DbSet<SupplierPartIndex> StockroomSupplierPartIndices { get; set; }
        public DbSet<RequestLine> StockroomRequestLines { get; set; }
        public DbSet<Order> StockroomOrders { get; set; }
        public DbSet<OrderLine> StockroomOrderLines { get; set; }
        public DbSet<OrderNote> StockroomOrderNotes { get; set; }
        //logbook databases
         public DbSet<LogbookGeneralStatus> LogbookGeneralStatuses { get; set; }
         public DbSet<LogbookGeneral> LogbookGeneral { get; set; }
         public DbSet<LogbookStockroomOrder> LogbookStockroomOrders { get; set; }
         public DbSet<LogbookStockroomRequest> LogbookStockroomRequests { get; set; }
         public DbSet<LogbookWorkOrder> LogbookWorkOrders { get; set; } 
        //admin databases (Settings, Permissions, defaults)
        //todo
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