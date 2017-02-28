namespace CIS467_AMP.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MoreModelFixes : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.IssueIndexes", name: "Class_Id", newName: "ClassOfissue_Id");
            RenameColumn(table: "dbo.JobPlanParts", name: "PartId_Id", newName: "Part_Id");
            RenameColumn(table: "dbo.LogbookRecords", name: "Asset_Id", newName: "AssetInventory_Id");
            RenameColumn(table: "dbo.WorkOrders", name: "Asset_Id", newName: "AssetInventory_Id");
            RenameIndex(table: "dbo.IssueIndexes", name: "IX_Class_Id", newName: "IX_ClassOfissue_Id");
            RenameIndex(table: "dbo.JobPlanParts", name: "IX_PartId_Id", newName: "IX_Part_Id");
            RenameIndex(table: "dbo.LogbookRecords", name: "IX_Asset_Id", newName: "IX_AssetInventory_Id");
            RenameIndex(table: "dbo.WorkOrders", name: "IX_Asset_Id", newName: "IX_AssetInventory_Id");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.WorkOrders", name: "IX_AssetInventory_Id", newName: "IX_Asset_Id");
            RenameIndex(table: "dbo.LogbookRecords", name: "IX_AssetInventory_Id", newName: "IX_Asset_Id");
            RenameIndex(table: "dbo.JobPlanParts", name: "IX_Part_Id", newName: "IX_PartId_Id");
            RenameIndex(table: "dbo.IssueIndexes", name: "IX_ClassOfissue_Id", newName: "IX_Class_Id");
            RenameColumn(table: "dbo.WorkOrders", name: "AssetInventory_Id", newName: "Asset_Id");
            RenameColumn(table: "dbo.LogbookRecords", name: "AssetInventory_Id", newName: "Asset_Id");
            RenameColumn(table: "dbo.JobPlanParts", name: "Part_Id", newName: "PartId_Id");
            RenameColumn(table: "dbo.IssueIndexes", name: "ClassOfissue_Id", newName: "Class_Id");
        }
    }
}
