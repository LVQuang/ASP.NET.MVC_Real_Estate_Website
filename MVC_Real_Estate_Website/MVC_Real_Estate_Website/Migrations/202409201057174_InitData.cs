namespace Real_Estate_Website.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitData : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Category",
                c => new
                    {
                        id = c.Int(nullable: false),
                        name = c.String(maxLength: 50),
                        link = c.String(),
                        meta = c.String(maxLength: 50),
                        hide = c.Boolean(),
                        order = c.Int(),
                        datebegin = c.DateTime(storeType: "smalldatetime"),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Category");
        }
    }
}
