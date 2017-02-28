namespace CIS467_AMP.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddRequestStatus : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.RequestStatus",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Requests", "RequestStatus_Id", c => c.Int());
            CreateIndex("dbo.Requests", "RequestStatus_Id");
            AddForeignKey("dbo.Requests", "RequestStatus_Id", "dbo.RequestStatus", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Requests", "RequestStatus_Id", "dbo.RequestStatus");
            DropIndex("dbo.Requests", new[] { "RequestStatus_Id" });
            DropColumn("dbo.Requests", "RequestStatus_Id");
            DropTable("dbo.RequestStatus");
        }
    }
}
