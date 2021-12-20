namespace Ankh_Morpork_webapp_MVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ApplyAnnotationsToName : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Assassins", "Name", c => c.String(nullable: false, maxLength: 255));
            AlterColumn("dbo.Beggars", "Name", c => c.String(nullable: false, maxLength: 255));
            AlterColumn("dbo.Fools", "Name", c => c.String(nullable: false, maxLength: 255));
            AlterColumn("dbo.Thieves", "Name", c => c.String(nullable: false, maxLength: 255));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Thieves", "Name", c => c.String());
            AlterColumn("dbo.Fools", "Name", c => c.String());
            AlterColumn("dbo.Beggars", "Name", c => c.String());
            AlterColumn("dbo.Assassins", "Name", c => c.String());
        }
    }
}
