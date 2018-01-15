namespace Contoso.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangePeopleColName : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.People", "LastName", c => c.String());
            DropColumn("dbo.People", "LastTime");
        }
        
        public override void Down()
        {
            AddColumn("dbo.People", "LastTime", c => c.String());
            DropColumn("dbo.People", "LastName");
        }
    }
}
