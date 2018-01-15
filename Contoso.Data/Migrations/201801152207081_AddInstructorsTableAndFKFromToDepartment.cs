namespace Contoso.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddInstructorsTableAndFKFromToDepartment : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Instructor",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        HireDate = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.People", t => t.Id)
                .Index(t => t.Id);
            
            AddColumn("dbo.Departments", "InstructorId", c => c.Int(nullable: false));
            CreateIndex("dbo.Departments", "InstructorId");
            AddForeignKey("dbo.Departments", "InstructorId", "dbo.Instructor", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Instructor", "Id", "dbo.People");
            DropForeignKey("dbo.Departments", "InstructorId", "dbo.Instructor");
            DropIndex("dbo.Instructor", new[] { "Id" });
            DropIndex("dbo.Departments", new[] { "InstructorId" });
            DropColumn("dbo.Departments", "InstructorId");
            DropTable("dbo.Instructor");
        }
    }
}
