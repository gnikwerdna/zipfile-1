namespace SynergeticHelper.DB.synhelpcontext
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initialcreate3 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Staffs", "NetworkLogin", c => c.String());
            AddColumn("dbo.Staffs", "StaffDepartment", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Staffs", "StaffDepartment");
            DropColumn("dbo.Staffs", "NetworkLogin");
        }
    }
}
