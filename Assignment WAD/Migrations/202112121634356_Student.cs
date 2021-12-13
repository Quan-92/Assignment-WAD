namespace Assignment_WAD.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Student : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.StudentsLates");
            AddColumn("dbo.StudentsLates", "Quantily", c => c.Int(nullable: false));
            AddColumn("dbo.StudentsLates", "PenaltyDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.StudentsLates", "RollNumber", c => c.Int(nullable: false, identity: true));
            AlterColumn("dbo.StudentsLates", "FullName", c => c.String(nullable: false));
            AlterColumn("dbo.StudentsLates", "Method", c => c.String(nullable: false));
            AddPrimaryKey("dbo.StudentsLates", "RollNumber");
            DropColumn("dbo.StudentsLates", "Id");
            DropColumn("dbo.StudentsLates", "Fines");
            DropColumn("dbo.StudentsLates", "Date");
        }
        
        public override void Down()
        {
            AddColumn("dbo.StudentsLates", "Date", c => c.Int(nullable: false));
            AddColumn("dbo.StudentsLates", "Fines", c => c.Int(nullable: false));
            AddColumn("dbo.StudentsLates", "Id", c => c.Int(nullable: false, identity: true));
            DropPrimaryKey("dbo.StudentsLates");
            AlterColumn("dbo.StudentsLates", "Method", c => c.Int(nullable: false));
            AlterColumn("dbo.StudentsLates", "FullName", c => c.Int(nullable: false));
            AlterColumn("dbo.StudentsLates", "RollNumber", c => c.Int(nullable: false));
            DropColumn("dbo.StudentsLates", "PenaltyDate");
            DropColumn("dbo.StudentsLates", "Quantily");
            AddPrimaryKey("dbo.StudentsLates", "Id");
        }
    }
}
