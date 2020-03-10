namespace Service1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Service : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Departments",
                c => new
                    {
                        D_id = c.Int(nullable: false, identity: true),
                        D_name = c.String(nullable: false),
                        location = c.String(),
                    })
                .PrimaryKey(t => t.D_id);
            
            CreateTable(
                "dbo.Employees",
                c => new
                    {
                        E_id = c.Int(nullable: false, identity: true),
                        E_name = c.String(nullable: false),
                        designation = c.String(),
                        SALARY = c.Double(nullable: false),
                        D_id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.E_id)
                .ForeignKey("dbo.Departments", t => t.D_id, cascadeDelete: true)
                .Index(t => t.D_id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Employees", "D_id", "dbo.Departments");
            DropIndex("dbo.Employees", new[] { "D_id" });
            DropTable("dbo.Employees");
            DropTable("dbo.Departments");
        }
    }
}
