namespace Oct3Assignment.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddImage : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Employes", "Image", c => c.String());
            DropColumn("dbo.Employes", "ImageUrl");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Employes", "ImageUrl", c => c.String());
            DropColumn("dbo.Employes", "Image");
        }
    }
}
