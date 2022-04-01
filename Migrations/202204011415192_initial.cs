namespace GeneralInsuranceProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.RegistrationTB",
                c => new
                    {
                        Reg_Id = c.Int(nullable: false, identity: true),
                        CustomerName = c.String(nullable: false),
                        Email = c.String(nullable: false),
                        DOB = c.String(nullable: false),
                        PhoneNumber = c.Int(nullable: false),
                        Address = c.String(nullable: false),
                        Password = c.String(nullable: false),
                        Confirm_Password = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Reg_Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.RegistrationTB");
        }
    }
}
