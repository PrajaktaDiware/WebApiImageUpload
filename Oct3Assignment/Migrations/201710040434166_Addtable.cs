namespace Oct3Assignment.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Addtable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.PStudents",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ChildFirstName = c.String(),
                        ChildLastName = c.String(),
                        ChildGender = c.String(),
                        Address = c.String(),
                        City = c.String(),
                        PostalCode = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.PStudents");
        }
    }
}
