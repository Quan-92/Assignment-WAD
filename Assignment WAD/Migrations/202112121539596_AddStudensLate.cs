namespace Assignment_WAD.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddStudensLate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.StudentsLates",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        RollNumber = c.Int(nullable: false),
                        FullName = c.Int(nullable: false),
                        Method = c.Int(nullable: false),
                        Fines = c.Int(nullable: false),
                        Date = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.StudentsLates");
        }
    }
}
