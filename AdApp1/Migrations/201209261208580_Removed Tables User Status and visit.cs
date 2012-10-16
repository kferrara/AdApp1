namespace AdApp1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemovedTablesUserStatusandvisit : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.User", "Person_PersonId", "dbo.Person");
            DropForeignKey("dbo.User", "Status_StatusTypeId", "dbo.StatusType");
            DropForeignKey("dbo.RoleType", "User_UserId", "dbo.User");
            DropForeignKey("dbo.Visit", "User_UserId", "dbo.User");
            DropIndex("dbo.User", new[] { "Person_PersonId" });
            DropIndex("dbo.User", new[] { "Status_StatusTypeId" });
            DropIndex("dbo.RoleType", new[] { "User_UserId" });
            DropIndex("dbo.Visit", new[] { "User_UserId" });
            DropTable("dbo.User");
            DropTable("dbo.RoleType");
            DropTable("dbo.StatusType");
            DropTable("dbo.Visit");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Visit",
                c => new
                    {
                        VisitId = c.Int(nullable: false, identity: true),
                        When = c.DateTime(nullable: false),
                        User_UserId = c.Int(),
                    })
                .PrimaryKey(t => t.VisitId);
            
            CreateTable(
                "dbo.StatusType",
                c => new
                    {
                        StatusTypeId = c.Int(nullable: false, identity: true),
                        Type = c.String(),
                    })
                .PrimaryKey(t => t.StatusTypeId);
            
            CreateTable(
                "dbo.RoleType",
                c => new
                    {
                        RoleTypeId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        User_UserId = c.Int(),
                    })
                .PrimaryKey(t => t.RoleTypeId);
            
            CreateTable(
                "dbo.User",
                c => new
                    {
                        UserId = c.Int(nullable: false, identity: true),
                        Person_PersonId = c.Int(),
                        Status_StatusTypeId = c.Int(),
                    })
                .PrimaryKey(t => t.UserId);
            
            CreateIndex("dbo.Visit", "User_UserId");
            CreateIndex("dbo.RoleType", "User_UserId");
            CreateIndex("dbo.User", "Status_StatusTypeId");
            CreateIndex("dbo.User", "Person_PersonId");
            AddForeignKey("dbo.Visit", "User_UserId", "dbo.User", "UserId");
            AddForeignKey("dbo.RoleType", "User_UserId", "dbo.User", "UserId");
            AddForeignKey("dbo.User", "Status_StatusTypeId", "dbo.StatusType", "StatusTypeId");
            AddForeignKey("dbo.User", "Person_PersonId", "dbo.Person", "PersonId");
        }
    }
}
