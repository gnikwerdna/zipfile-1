namespace SynergeticHelper.DB.synhelpcontext
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initialcreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Staffs",
                c => new
                    {
                        staffId = c.Int(nullable: false, identity: true),
                        fname = c.String(),
                        lname = c.String(),
                    })
                .PrimaryKey(t => t.staffId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Staffs");
        }
    }
}
