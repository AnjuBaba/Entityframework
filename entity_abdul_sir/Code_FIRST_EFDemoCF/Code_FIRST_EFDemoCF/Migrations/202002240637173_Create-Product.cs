namespace Code_FIRST_EFDemoCF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateProduct : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        Pid = c.Int(nullable: false, identity: true),
                        Ptitle = c.String(nullable: false),
                        Price = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.Pid);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Products");
        }
    }
}
