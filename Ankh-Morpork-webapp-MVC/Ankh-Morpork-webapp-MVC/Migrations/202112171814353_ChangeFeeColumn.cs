namespace Ankh_Morpork_webapp_MVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeFeeColumn : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Beggars", "Fee", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.Fools", "Fee", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            DropColumn("dbo.Beggars", "Alms");
            DropColumn("dbo.Fools", "Salary");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Fools", "Salary", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.Beggars", "Alms", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            DropColumn("dbo.Fools", "Fee");
            DropColumn("dbo.Beggars", "Fee");
        }
    }
}
