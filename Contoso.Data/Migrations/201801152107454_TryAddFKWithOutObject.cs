namespace Contoso.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TryAddFKWithOutObject : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Enrollments", "CourseId", c => c.Int(nullable: false));
            AddColumn("dbo.Enrollments", "StudentId", c => c.Int(nullable: false));
            CreateIndex("dbo.Enrollments", "CourseId");
            CreateIndex("dbo.Enrollments", "StudentId");
            AddForeignKey("dbo.Enrollments", "CourseId", "dbo.Courses", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Enrollments", "StudentId", "dbo.Student", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Enrollments", "StudentId", "dbo.Student");
            DropForeignKey("dbo.Enrollments", "CourseId", "dbo.Courses");
            DropIndex("dbo.Enrollments", new[] { "StudentId" });
            DropIndex("dbo.Enrollments", new[] { "CourseId" });
            DropColumn("dbo.Enrollments", "StudentId");
            DropColumn("dbo.Enrollments", "CourseId");
        }
    }
}
