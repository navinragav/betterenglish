namespace BetterEnglishWebApplication123.Migrations
{
    using BetterEnglishWebApplication123.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<BetterEnglishWebApplication123.DAL.SchoolContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(BetterEnglishWebApplication123.DAL.SchoolContext context)
        {
            var students = new List<Student>
            {
              new Student{StudentID="1", Date=DateTime.Parse("2016-09-01"), FirstName="Carson", LastName="Alexander", DOB=DateTime.Parse("1980-09-01"), Address="23 Mount estuce,Tyrrelstown",Education="Degree",ContactNumber=0832280464},
              new Student{StudentID="2",Date=DateTime.Parse("2016-11-07"),FirstName="Aren", LastName="Harbor",DOB=DateTime.Parse("1982-08-11"),Address="45 Amiens street,Blanchardstown",Education="Degree",ContactNumber=0832280422},
              new Student{StudentID="3",Date=DateTime.Parse("2017-03-31"),FirstName="Gim",LastName="Khan",DOB=DateTime.Parse("1981-02-21"),Address="10 Anglesa Road,Lucan",Education="Degree",ContactNumber=0832280432},
              new Student{StudentID="4",Date=DateTime.Parse("2016-08-21"),FirstName="Him",LastName="Lee",DOB=DateTime.Parse("1975-03-14"),Address="93 baggot street,Hollistown",Education="Degree",ContactNumber=0832280467},
              new Student{StudentID="5",Date=DateTime.Parse("2017-06-01"),FirstName="Tim",LastName="Aboullov",DOB=DateTime.Parse("1971-09-21"),Address="62 Dame street,Tallaght",Education="Degree",ContactNumber=0832280424},
              new Student{StudentID="6",Date=DateTime.Parse("2016-12-30"),FirstName="Eric",LastName="Faherty",DOB=DateTime.Parse("1969-10-07"),Address="11 ballentree crescent,woodstown",Education="Degree",ContactNumber=0832280498},
              new Student{StudentID="7",Date=DateTime.Parse("2016-04-18"),FirstName="Edmount",LastName="Harbor",DOB=DateTime.Parse("1977-08-20"),Address="89 Mountrise,knocklyn",Education="Degree",ContactNumber=0832280465},
              new Student{StudentID="8",Date=DateTime.Parse("2017-07-27"),FirstName="Mathew",LastName="Roger",DOB=DateTime.Parse("1985-12-01"),Address="120 oConnor street,dublin",Education="Degree",ContactNumber=0832280433},
              new Student{StudentID="9",Date=DateTime.Parse("2016-02-19"),FirstName="Gemini",LastName="Khan",DOB=DateTime.Parse("1984-05-28"),Address="52 Mainstreet,Ongar",Education="Degree",ContactNumber=0832280482},
            };

            students.ForEach(s => context.Students.Add(s));
            context.SaveChanges();
            var courses = new List<Course>
            {
             new Course{CourseID="1",scheduleIn=DateTime.Parse("2017-06-01"),scheduleEnd=DateTime.Parse("2017-08-03"),cardNo="3424567890123456" ,ExpiresDate=DateTime.Parse("2020-10-01"),CardName="Navin",CVN=123},
             new Course{CourseID="2",scheduleIn=DateTime.Parse("2017-06-20"),scheduleEnd=DateTime.Parse("2017-08-14"),cardNo="9874567890123451" ,ExpiresDate=DateTime.Parse("2018-03-01"),CardName="Raman",CVN=989},
            new Course { CourseID="3",scheduleIn=DateTime.Parse("2017-06-30"),scheduleEnd=DateTime.Parse("2017-08-28"),cardNo="3214567890123458" ,ExpiresDate=DateTime.Parse("2019-04-01"),CardName="Selvi",CVN=189},




            };
            courses.ForEach(s => context.Courses.Add(s));
            context.SaveChanges();
            var enrollments = new List<Enrollment>
            {
            new Enrollment{EnrollmentID="X123", StudentID="1",CourseID="1",Grade=Grade.A},
            new Enrollment{EnrollmentID="X124", StudentID="2",CourseID="2",Grade=Grade.C},
            new Enrollment{EnrollmentID="X125", StudentID="3",CourseID="3",Grade=Grade.B},
            new Enrollment{EnrollmentID="X126", StudentID="4",CourseID="1",Grade=Grade.B},
            new Enrollment{EnrollmentID="X127", StudentID="5",CourseID="2",Grade=Grade.F},
            new Enrollment{EnrollmentID="X128", StudentID="5",CourseID="3",Grade=Grade.F},
            new Enrollment{EnrollmentID="X129", StudentID="1",CourseID="1", Grade=Grade.B},
            new Enrollment{EnrollmentID="X130", StudentID="2",CourseID="2", Grade=Grade.C},
            new Enrollment{EnrollmentID="X131", StudentID="7",CourseID="3",Grade=Grade.F},
            new Enrollment{EnrollmentID="X132", StudentID="9",CourseID="1",Grade=Grade.C},
            new Enrollment{EnrollmentID="X133", StudentID="8",CourseID="2", Grade=Grade.F},
            new Enrollment{EnrollmentID="X134", StudentID="3",CourseID="3",Grade=Grade.A},
            };
            enrollments.ForEach(s => context.Enrollments.Add(s));
            context.SaveChanges();
        }
    }
}