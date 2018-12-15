namespace Projist.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class projist : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserEmail = c.String(unicode: false),
                        UserPassword = c.String(unicode: false),
                        UserType = c.Int(nullable: false),
                        UserRegisterDate = c.DateTime(nullable: false, precision: 0),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Users");
        }
    }
}
