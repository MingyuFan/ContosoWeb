namespace Contoso.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TryLetInstructorIdInDepNullable : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.Departments", new[] { "InstructorId" });
            AlterColumn("dbo.Departments", "InstructorId", c => c.Int());
            CreateIndex("dbo.Departments", "InstructorId");
        }
        
        public override void Down()
        {
            DropIndex("dbo.Departments", new[] { "InstructorId" });
            AlterColumn("dbo.Departments", "InstructorId", c => c.Int(nullable: false));
            CreateIndex("dbo.Departments", "InstructorId");
        }
    }
}
