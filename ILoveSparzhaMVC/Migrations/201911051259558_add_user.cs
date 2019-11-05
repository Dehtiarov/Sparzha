namespace ILoveSparzhaMVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class add_user : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Email = c.String(nullable: false, maxLength: 100),
                        Name = c.String(nullable: false, maxLength: 100),
                        CreatedDate = c.DateTime(nullable: false),
                        Counter = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Users");
        }
    }
}
