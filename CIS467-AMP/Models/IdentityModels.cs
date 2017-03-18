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
        public DbSet<Worker> Workers { get; set; }
        public DbSet<AssetType> AssetTypes { get; set; }
        public DbSet<ManufacturerPart> ManufacturerParts { get; set; }
        public DbSet<WorkGroupSupervisor> WorkGroupSupervisors { get; set; }
        public DbSet<ManufacturerPartParentIndex> ManufacturerPartParentIndexes { get; set; }
        public DbSet<AssetInventory> AssetInventories { get; set; }
        public DbSet<JobPlan> JobPlans { get; set; }
        public DbSet<JobPlanDocument> JobPlanDocuments { get; set; }
        public DbSet<JobPlanPart> JobPlanParts { get; set; }
        //Maintenance databases
        public DbSet<MaintenanceClassOfIssue> MaintenanceClassOfIssues { get; set; }
        public DbSet<MaintenanceIssue> MaintenanceIssues { get; set; }
        public DbSet<MaintenanceStatus> MaintenanceStatuses { get; set; }
        public DbSet<MaintenanceType> MaintenanceTypes { get; set; }
        public DbSet<MaintenanceIssueIndex> MaintenanceIssueIndexes { get; set; }
        public DbSet<MaintenanceWorkOrder> MaintenanceWorkOrders { get; set; }
        public DbSet<MaintenanceWorkOrderPartIndex> MaintenanceWorkOrderPartIndexes { get; set; }
        public DbSet<MaintenanceWorkOrderWorkTime> MaintenanceWorkOrderWorkTime { get; set; }
        //stockroom databases
        public DbSet<StockRoomOrderStatus> StockRoomOrderStatuses { get; set; }
        public DbSet<StockRoomRequestStatus> StockRoomRequestStatuses { get; set; }
        public DbSet<StockRoomSupplier> StockRoomSuppliers { get; set; }
        public DbSet<StockRoomRequest> StockRoomRequests { get; set; }
        public DbSet<StockRoomInventory> StockRoomInventories { get; set; }
        public DbSet<StockRoomSupplierContact> StockroomSupplierContacts { get; set; }
        public DbSet<StockRoomSupplierPartIndex> StockroomSupplierPartIndexes { get; set; }
        public DbSet<StockRoomRequestLine> StockroomRequestLines { get; set; }
        public DbSet<StockRoomOrder> StockroomOrders { get; set; }
        public DbSet<StockRoomOrderLine> StockroomOrderLines { get; set; }
        public DbSet<StockRoomOrderNote> StockroomOrderNotes { get; set; }
        public DbSet<StockRoomSpecialOrderLine> StockRoomSpecialOrderLines { get; set; }
        //logbook databases
        public DbSet<LogbookGeneralStatus> LogbookGeneralStatuses { get; set; }
        public DbSet<LogbookGeneral> LogbookGeneral { get; set; }
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
