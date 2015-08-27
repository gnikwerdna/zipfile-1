namespace SynergeticHelper.DB.synhelpcontext
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initialcreate2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Staffs", "SynergeticId", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Staffs", "SynergeticId");
        }
    }
}
