namespace CIS467_AMP.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class VariousFixes : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.AssetTypes", name: "ManId_Id", newName: "Manufacturer_Id");
            RenameColumn(table: "dbo.AssetInventories", name: "AssetName_Id", newName: "AssetType_Id");
            RenameColumn(table: "dbo.AssetInventories", name: "MapId_Id", newName: "Map_Id");
            RenameColumn(table: "dbo.Variants", name: "AssetTypeId_Id", newName: "AssetType_Id");
            RenameColumn(table: "dbo.AssetInventories", name: "VariantId_Id", newName: "Variant_Id");
            RenameColumn(table: "dbo.IssueIndexes", name: "ClassId_Id", newName: "Class_Id");
            RenameColumn(table: "dbo.IssueIndexes", name: "IssueId_Id", newName: "Issue_Id");
            RenameColumn(table: "dbo.JobPlans", name: "VariantId_Id", newName: "Variant_Id");
            RenameColumn(table: "dbo.JobPlanDocuments", name: "JobPlanId_Id", newName: "JobPlan_Id");
            RenameColumn(table: "dbo.JobPlanParts", name: "JobPlanId_Id", newName: "JobPlan_Id");
            RenameColumn(table: "dbo.Parts", name: "ManId_Id", newName: "Manufacturer_Id");
            RenameColumn(table: "dbo.LogbookRecords", name: "AssetId_Id", newName: "Asset_Id");
            RenameColumn(table: "dbo.LogbookStatus", name: "TypeId_Id", newName: "LogbookType_Id");
            RenameColumn(table: "dbo.LogbookRecords", name: "StatusId_Id", newName: "LogbookStatus_Id");
            RenameColumn(table: "dbo.LogbookRecords", name: "TypeId_Id", newName: "LogbookType_Id");
            RenameColumn(table: "dbo.Workers", name: "WorkGroupId_Id", newName: "WorkGroup_Id");
            RenameColumn(table: "dbo.LogbookRecords", name: "WorkerId_Id", newName: "Worker_Id");
            RenameColumn(table: "dbo.PartsListIndexes", name: "PartId_Id", newName: "Part_Id");
            RenameColumn(table: "dbo.PartsListIndexes", name: "VariantId_Id", newName: "Variant_Id");
            RenameColumn(table: "dbo.PartIndexes", name: "PartsIndex_Id", newName: "PartsListIndex_Id");
            RenameColumn(table: "dbo.WorkOrders", name: "AssetId_Id", newName: "Asset_Id");
            RenameColumn(table: "dbo.WorkOrders", name: "CreatorId_Id", newName: "Creator_Id");
            RenameColumn(table: "dbo.WorkOrders", name: "IssueId_Id", newName: "Issue_Id");
            RenameColumn(table: "dbo.WorkOrders", name: "JobPlanId_Id", newName: "JobPlan_Id");
            RenameColumn(table: "dbo.WorkOrders", name: "LeadWorkerId_Id", newName: "LeadWorker_Id");
            RenameColumn(table: "dbo.WorkOrders", name: "SupervisorId_Id", newName: "Supervisor_Id");
            RenameColumn(table: "dbo.PartIndexes", name: "WorkOrderId_Id", newName: "WorkOrder_Id");
            RenameColumn(table: "dbo.WorkTimes", name: "WorkerId_Id", newName: "Worker_Id");
            RenameColumn(table: "dbo.WorkTimes", name: "WorkOrderId_Id", newName: "WorkOrder_Id");
            RenameColumn(table: "dbo.ManufacturerContacts", name: "ManufacturerId_Id", newName: "Manufacturer_Id");
            RenameColumn(table: "dbo.WorkGroupSupervisors", name: "WorkerId_Id", newName: "Worker_Id");
            RenameColumn(table: "dbo.WorkGroupSupervisors", name: "WorkGroupId_Id", newName: "WorkGroup_Id");
            RenameIndex(table: "dbo.AssetInventories", name: "IX_AssetName_Id", newName: "IX_AssetType_Id");
            RenameIndex(table: "dbo.AssetInventories", name: "IX_MapId_Id", newName: "IX_Map_Id");
            RenameIndex(table: "dbo.AssetInventories", name: "IX_VariantId_Id", newName: "IX_Variant_Id");
            RenameIndex(table: "dbo.AssetTypes", name: "IX_ManId_Id", newName: "IX_Manufacturer_Id");
            RenameIndex(table: "dbo.Variants", name: "IX_AssetTypeId_Id", newName: "IX_AssetType_Id");
            RenameIndex(table: "dbo.IssueIndexes", name: "IX_ClassId_Id", newName: "IX_Class_Id");
            RenameIndex(table: "dbo.IssueIndexes", name: "IX_IssueId_Id", newName: "IX_Issue_Id");
            RenameIndex(table: "dbo.JobPlanDocuments", name: "IX_JobPlanId_Id", newName: "IX_JobPlan_Id");
            RenameIndex(table: "dbo.JobPlans", name: "IX_VariantId_Id", newName: "IX_Variant_Id");
            RenameIndex(table: "dbo.JobPlanParts", name: "IX_JobPlanId_Id", newName: "IX_JobPlan_Id");
            RenameIndex(table: "dbo.Parts", name: "IX_ManId_Id", newName: "IX_Manufacturer_Id");
            RenameIndex(table: "dbo.LogbookRecords", name: "IX_AssetId_Id", newName: "IX_Asset_Id");
            RenameIndex(table: "dbo.LogbookRecords", name: "IX_StatusId_Id", newName: "IX_LogbookStatus_Id");
            RenameIndex(table: "dbo.LogbookRecords", name: "IX_TypeId_Id", newName: "IX_LogbookType_Id");
            RenameIndex(table: "dbo.LogbookRecords", name: "IX_WorkerId_Id", newName: "IX_Worker_Id");
            RenameIndex(table: "dbo.LogbookStatus", name: "IX_TypeId_Id", newName: "IX_LogbookType_Id");
            RenameIndex(table: "dbo.Workers", name: "IX_WorkGroupId_Id", newName: "IX_WorkGroup_Id");
            RenameIndex(table: "dbo.PartIndexes", name: "IX_PartsIndex_Id", newName: "IX_PartsListIndex_Id");
            RenameIndex(table: "dbo.PartIndexes", name: "IX_WorkOrderId_Id", newName: "IX_WorkOrder_Id");
            RenameIndex(table: "dbo.PartsListIndexes", name: "IX_PartId_Id", newName: "IX_Part_Id");
            RenameIndex(table: "dbo.PartsListIndexes", name: "IX_VariantId_Id", newName: "IX_Variant_Id");
            RenameIndex(table: "dbo.WorkOrders", name: "IX_AssetId_Id", newName: "IX_Asset_Id");
            RenameIndex(table: "dbo.WorkOrders", name: "IX_CreatorId_Id", newName: "IX_Creator_Id");
            RenameIndex(table: "dbo.WorkOrders", name: "IX_IssueId_Id", newName: "IX_Issue_Id");
            RenameIndex(table: "dbo.WorkOrders", name: "IX_JobPlanId_Id", newName: "IX_JobPlan_Id");
            RenameIndex(table: "dbo.WorkOrders", name: "IX_LeadWorkerId_Id", newName: "IX_LeadWorker_Id");
            RenameIndex(table: "dbo.WorkOrders", name: "IX_SupervisorId_Id", newName: "IX_Supervisor_Id");
            RenameIndex(table: "dbo.WorkTimes", name: "IX_WorkerId_Id", newName: "IX_Worker_Id");
            RenameIndex(table: "dbo.WorkTimes", name: "IX_WorkOrderId_Id", newName: "IX_WorkOrder_Id");
            RenameIndex(table: "dbo.ManufacturerContacts", name: "IX_ManufacturerId_Id", newName: "IX_Manufacturer_Id");
            RenameIndex(table: "dbo.WorkGroupSupervisors", name: "IX_WorkerId_Id", newName: "IX_Worker_Id");
            RenameIndex(table: "dbo.WorkGroupSupervisors", name: "IX_WorkGroupId_Id", newName: "IX_WorkGroup_Id");
            CreateTable(
                "dbo.PartTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.AssetTypes", "Name", c => c.String());
            AddColumn("dbo.Maps", "Longitude", c => c.Single(nullable: false));
            AddColumn("dbo.Maps", "Latitude", c => c.Single(nullable: false));
            AddColumn("dbo.Parts", "PartType_Id", c => c.Int());
            AddColumn("dbo.Workers", "Employee", c => c.String());
            CreateIndex("dbo.Parts", "PartType_Id");
            AddForeignKey("dbo.Parts", "PartType_Id", "dbo.PartTypes", "Id");
            DropColumn("dbo.AssetTypes", "AssetName");
            DropColumn("dbo.AssetTypes", "PartNumber");
            DropColumn("dbo.Parts", "PartType");
            DropColumn("dbo.Workers", "EmployeeId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Workers", "EmployeeId", c => c.String());
            AddColumn("dbo.Parts", "PartType", c => c.Int(nullable: false));
            AddColumn("dbo.AssetTypes", "PartNumber", c => c.String());
            AddColumn("dbo.AssetTypes", "AssetName", c => c.String());
            DropForeignKey("dbo.Parts", "PartType_Id", "dbo.PartTypes");
            DropIndex("dbo.Parts", new[] { "PartType_Id" });
            DropColumn("dbo.Workers", "Employee");
            DropColumn("dbo.Parts", "PartType_Id");
            DropColumn("dbo.Maps", "Latitude");
            DropColumn("dbo.Maps", "Longitude");
            DropColumn("dbo.AssetTypes", "Name");
            DropTable("dbo.PartTypes");
            RenameIndex(table: "dbo.WorkGroupSupervisors", name: "IX_WorkGroup_Id", newName: "IX_WorkGroupId_Id");
            RenameIndex(table: "dbo.WorkGroupSupervisors", name: "IX_Worker_Id", newName: "IX_WorkerId_Id");
            RenameIndex(table: "dbo.ManufacturerContacts", name: "IX_Manufacturer_Id", newName: "IX_ManufacturerId_Id");
            RenameIndex(table: "dbo.WorkTimes", name: "IX_WorkOrder_Id", newName: "IX_WorkOrderId_Id");
            RenameIndex(table: "dbo.WorkTimes", name: "IX_Worker_Id", newName: "IX_WorkerId_Id");
            RenameIndex(table: "dbo.WorkOrders", name: "IX_Supervisor_Id", newName: "IX_SupervisorId_Id");
            RenameIndex(table: "dbo.WorkOrders", name: "IX_LeadWorker_Id", newName: "IX_LeadWorkerId_Id");
            RenameIndex(table: "dbo.WorkOrders", name: "IX_JobPlan_Id", newName: "IX_JobPlanId_Id");
            RenameIndex(table: "dbo.WorkOrders", name: "IX_Issue_Id", newName: "IX_IssueId_Id");
            RenameIndex(table: "dbo.WorkOrders", name: "IX_Creator_Id", newName: "IX_CreatorId_Id");
            RenameIndex(table: "dbo.WorkOrders", name: "IX_Asset_Id", newName: "IX_AssetId_Id");
            RenameIndex(table: "dbo.PartsListIndexes", name: "IX_Variant_Id", newName: "IX_VariantId_Id");
            RenameIndex(table: "dbo.PartsListIndexes", name: "IX_Part_Id", newName: "IX_PartId_Id");
            RenameIndex(table: "dbo.PartIndexes", name: "IX_WorkOrder_Id", newName: "IX_WorkOrderId_Id");
            RenameIndex(table: "dbo.PartIndexes", name: "IX_PartsListIndex_Id", newName: "IX_PartsIndex_Id");
            RenameIndex(table: "dbo.Workers", name: "IX_WorkGroup_Id", newName: "IX_WorkGroupId_Id");
            RenameIndex(table: "dbo.LogbookStatus", name: "IX_LogbookType_Id", newName: "IX_TypeId_Id");
            RenameIndex(table: "dbo.LogbookRecords", name: "IX_Worker_Id", newName: "IX_WorkerId_Id");
            RenameIndex(table: "dbo.LogbookRecords", name: "IX_LogbookType_Id", newName: "IX_TypeId_Id");
            RenameIndex(table: "dbo.LogbookRecords", name: "IX_LogbookStatus_Id", newName: "IX_StatusId_Id");
            RenameIndex(table: "dbo.LogbookRecords", name: "IX_Asset_Id", newName: "IX_AssetId_Id");
            RenameIndex(table: "dbo.Parts", name: "IX_Manufacturer_Id", newName: "IX_ManId_Id");
            RenameIndex(table: "dbo.JobPlanParts", name: "IX_JobPlan_Id", newName: "IX_JobPlanId_Id");
            RenameIndex(table: "dbo.JobPlans", name: "IX_Variant_Id", newName: "IX_VariantId_Id");
            RenameIndex(table: "dbo.JobPlanDocuments", name: "IX_JobPlan_Id", newName: "IX_JobPlanId_Id");
            RenameIndex(table: "dbo.IssueIndexes", name: "IX_Issue_Id", newName: "IX_IssueId_Id");
            RenameIndex(table: "dbo.IssueIndexes", name: "IX_Class_Id", newName: "IX_ClassId_Id");
            RenameIndex(table: "dbo.Variants", name: "IX_AssetType_Id", newName: "IX_AssetTypeId_Id");
            RenameIndex(table: "dbo.AssetTypes", name: "IX_Manufacturer_Id", newName: "IX_ManId_Id");
            RenameIndex(table: "dbo.AssetInventories", name: "IX_Variant_Id", newName: "IX_VariantId_Id");
            RenameIndex(table: "dbo.AssetInventories", name: "IX_Map_Id", newName: "IX_MapId_Id");
            RenameIndex(table: "dbo.AssetInventories", name: "IX_AssetType_Id", newName: "IX_AssetName_Id");
            RenameColumn(table: "dbo.WorkGroupSupervisors", name: "WorkGroup_Id", newName: "WorkGroupId_Id");
            RenameColumn(table: "dbo.WorkGroupSupervisors", name: "Worker_Id", newName: "WorkerId_Id");
            RenameColumn(table: "dbo.ManufacturerContacts", name: "Manufacturer_Id", newName: "ManufacturerId_Id");
            RenameColumn(table: "dbo.WorkTimes", name: "WorkOrder_Id", newName: "WorkOrderId_Id");
            RenameColumn(table: "dbo.WorkTimes", name: "Worker_Id", newName: "WorkerId_Id");
            RenameColumn(table: "dbo.PartIndexes", name: "WorkOrder_Id", newName: "WorkOrderId_Id");
            RenameColumn(table: "dbo.WorkOrders", name: "Supervisor_Id", newName: "SupervisorId_Id");
            RenameColumn(table: "dbo.WorkOrders", name: "LeadWorker_Id", newName: "LeadWorkerId_Id");
            RenameColumn(table: "dbo.WorkOrders", name: "JobPlan_Id", newName: "JobPlanId_Id");
            RenameColumn(table: "dbo.WorkOrders", name: "Issue_Id", newName: "IssueId_Id");
            RenameColumn(table: "dbo.WorkOrders", name: "Creator_Id", newName: "CreatorId_Id");
            RenameColumn(table: "dbo.WorkOrders", name: "Asset_Id", newName: "AssetId_Id");
            RenameColumn(table: "dbo.PartIndexes", name: "PartsListIndex_Id", newName: "PartsIndex_Id");
            RenameColumn(table: "dbo.PartsListIndexes", name: "Variant_Id", newName: "VariantId_Id");
            RenameColumn(table: "dbo.PartsListIndexes", name: "Part_Id", newName: "PartId_Id");
            RenameColumn(table: "dbo.LogbookRecords", name: "Worker_Id", newName: "WorkerId_Id");
            RenameColumn(table: "dbo.Workers", name: "WorkGroup_Id", newName: "WorkGroupId_Id");
            RenameColumn(table: "dbo.LogbookRecords", name: "LogbookType_Id", newName: "TypeId_Id");
            RenameColumn(table: "dbo.LogbookRecords", name: "LogbookStatus_Id", newName: "StatusId_Id");
            RenameColumn(table: "dbo.LogbookStatus", name: "LogbookType_Id", newName: "TypeId_Id");
            RenameColumn(table: "dbo.LogbookRecords", name: "Asset_Id", newName: "AssetId_Id");
            RenameColumn(table: "dbo.Parts", name: "Manufacturer_Id", newName: "ManId_Id");
            RenameColumn(table: "dbo.JobPlanParts", name: "JobPlan_Id", newName: "JobPlanId_Id");
            RenameColumn(table: "dbo.JobPlanDocuments", name: "JobPlan_Id", newName: "JobPlanId_Id");
            RenameColumn(table: "dbo.JobPlans", name: "Variant_Id", newName: "VariantId_Id");
            RenameColumn(table: "dbo.IssueIndexes", name: "Issue_Id", newName: "IssueId_Id");
            RenameColumn(table: "dbo.IssueIndexes", name: "Class_Id", newName: "ClassId_Id");
            RenameColumn(table: "dbo.AssetInventories", name: "Variant_Id", newName: "VariantId_Id");
            RenameColumn(table: "dbo.Variants", name: "AssetType_Id", newName: "AssetTypeId_Id");
            RenameColumn(table: "dbo.AssetInventories", name: "Map_Id", newName: "MapId_Id");
            RenameColumn(table: "dbo.AssetInventories", name: "AssetType_Id", newName: "AssetName_Id");
            RenameColumn(table: "dbo.AssetTypes", name: "Manufacturer_Id", newName: "ManId_Id");
        }
    }
}
