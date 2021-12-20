using Ankh_Morpork_webapp_MVC.Models;

namespace Ankh_Morpork_webapp_MVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateModel : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Thieves", "Fee", c => c.Decimal(nullable: false, precision: 18, scale: 2, defaultValue:10));
            Sql($"ALTER TABLE Thieves ADD CONSTRAINT df_Speech DEFAULT 'Pay the fee - 10 bucks, otherwise you will be robbed next time' FOR Speech");
        }
        
        public override void Down()
        {
            Sql($"ALTER TABLE Thieves ADD CONSTRAINT df_Speech DEFAULT NULL FOR Speech");
            DropColumn("dbo.Thieves", "Fee");
        }
    }
}
