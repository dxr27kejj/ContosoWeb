namespace Contoso.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdatedPeopleTableWithMoreColumns : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.People", "State", c => c.String());
            AddColumn("dbo.People", "ZipCode", c => c.String());
            AddColumn("dbo.People", "Phone", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.People", "Phone");
            DropColumn("dbo.People", "ZipCode");
            DropColumn("dbo.People", "State");
        }
    }
}
