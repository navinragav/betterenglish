namespace BetterEnglishWebApplication123.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Course",
                c => new
                    {
                        CourseID = c.String(nullable: false, maxLength: 128),
                        Type = c.Int(nullable: false),
                        Level = c.Int(nullable: false),
                        scheduleIn = c.DateTime(nullable: false),
                        scheduleEnd = c.DateTime(nullable: false),
                        payment = c.Int(nullable: false),
                        cardNo = c.String(nullable: false),
                        ExpiresDate = c.DateTime(nullable: false),
                        CardName = c.String(nullable: false, maxLength: 16),
                        CVN = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.CourseID);
            
            CreateTable(
                "dbo.Enrollment",
                c => new
                    {
                        EnrollmentID = c.String(nullable: false, maxLength: 128),
                        CourseID = c.String(maxLength: 128),
                        StudentID = c.String(maxLength: 128),
                        Grade = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.EnrollmentID)
                .ForeignKey("dbo.Course", t => t.CourseID)
                .ForeignKey("dbo.Student", t => t.StudentID)
                .Index(t => t.CourseID)
                .Index(t => t.StudentID);
            
            CreateTable(
                "dbo.Student",
                c => new
                    {
                        StudentID = c.String(nullable: false, maxLength: 128),
                        Date = c.DateTime(nullable: false),
                        FirstName = c.String(nullable: false, maxLength: 40),
                        LastName = c.String(nullable: false, maxLength: 40),
                        DOB = c.DateTime(nullable: false),
                        Address = c.String(nullable: false),
                        Gender = c.Int(nullable: false),
                        Education = c.String(nullable: false),
                        ContactNumber = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.StudentID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Enrollment", "StudentID", "dbo.Student");
            DropForeignKey("dbo.Enrollment", "CourseID", "dbo.Course");
            DropIndex("dbo.Enrollment", new[] { "StudentID" });
            DropIndex("dbo.Enrollment", new[] { "CourseID" });
            DropTable("dbo.Student");
            DropTable("dbo.Enrollment");
            DropTable("dbo.Course");
        }
    }
}
