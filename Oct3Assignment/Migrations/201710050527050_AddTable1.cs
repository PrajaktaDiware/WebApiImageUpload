namespace Oct3Assignment.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddTable1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Employes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Email = c.String(),
                        DOB = c.DateTime(nullable: false),
                        ImageUrl = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Employes");
        }
    }
}
