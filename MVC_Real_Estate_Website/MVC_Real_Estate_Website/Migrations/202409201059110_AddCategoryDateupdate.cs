namespace Real_Estate_Website.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddCategoryDateupdate : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Category", "dateupdate", c => c.DateTime(storeType: "smalldatetime"));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Category", "dateupdate");
        }
    }
}
