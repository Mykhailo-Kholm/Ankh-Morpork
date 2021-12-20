namespace Ankh_Morpork_webapp_MVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UppdateModels : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Assassins", "ImageUrl", c => c.String());
            AddColumn("dbo.Beggars", "ImageUrl", c => c.String());
            AddColumn("dbo.Fools", "ImageUrl", c => c.String());
            AddColumn("dbo.Thieves", "ImageUrl", c => c.String());
            DropColumn("dbo.Assassins", "Speech");
            DropColumn("dbo.Beggars", "Speech");
            DropColumn("dbo.Fools", "Speech");
            DropColumn("dbo.Thieves", "Speech");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Thieves", "Speech", c => c.String());
            AddColumn("dbo.Fools", "Speech", c => c.String());
            AddColumn("dbo.Beggars", "Speech", c => c.String());
            AddColumn("dbo.Assassins", "Speech", c => c.String());
            DropColumn("dbo.Thieves", "ImageUrl");
            DropColumn("dbo.Fools", "ImageUrl");
            DropColumn("dbo.Beggars", "ImageUrl");
            DropColumn("dbo.Assassins", "ImageUrl");
        }
    }
}
