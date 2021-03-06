﻿using BetterEnglishWebApplication123.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BetterEnglishWebApplication123.DAL
{
    public class SchoolInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<SchoolContext>
    {
        protected override void Seed(SchoolContext context)
        {
            var students = new List<Student>
            {
              new Student{StudentID="123", Date=DateTime.Parse("2016-09-01"), FirstName="Carson", LastName="Alexander", DOB=DateTime.Parse("1980-09-01"), Address="23 Mount estuce,Tyrrelstown",Education="Degree",ContactNumber=0832280464},
              new Student{StudentID="124",Date=DateTime.Parse("2016-11-07"),FirstName="Aren", LastName="Harbor",DOB=DateTime.Parse("1982-08-11"),Address="45 Amiens street,Blanchardstown",Education="Degree",ContactNumber=0832280422},
              new Student{StudentID="125",Date=DateTime.Parse("2017-03-31"),FirstName="Gim",LastName="Khan",DOB=DateTime.Parse("1981-02-21"),Address="10 Anglesa Road,Lucan",Education="Degree",ContactNumber=0832280432},
              new Student{StudentID="126",Date=DateTime.Parse("2016-08-21"),FirstName="Him",LastName="Lee",DOB=DateTime.Parse("1975-03-14"),Address="93 baggot street,Hollistown",Education="Degree",ContactNumber=0832280467},
              new Student{StudentID="127",Date=DateTime.Parse("2017-06-01"),FirstName="Tim",LastName="Aboullov",DOB=DateTime.Parse("1971-09-21"),Address="62 Dame street,Tallaght",Education="Degree",ContactNumber=0832280424},
              new Student{StudentID="128",Date=DateTime.Parse("2016-12-30"),FirstName="Eric",LastName="Faherty",DOB=DateTime.Parse("1969-10-07"),Address="11 ballentree crescent,woodstown",Education="Degree",ContactNumber=0832280498},
              new Student{StudentID="129",Date=DateTime.Parse("2016-04-18"),FirstName="Edmount",LastName="Harbor",DOB=DateTime.Parse("1977-08-20"),Address="89 Mountrise,knocklyn",Education="Degree",ContactNumber=0832280465},
              new Student{StudentID="130",Date=DateTime.Parse("2017-07-27"),FirstName="Mathew",LastName="Roger",DOB=DateTime.Parse("1985-12-01"),Address="120 oConnor street,dublin",Education="Degree",ContactNumber=0832280433},
              new Student{StudentID="131",Date=DateTime.Parse("2016-02-19"),FirstName="Gemini",LastName="Khan",DOB=DateTime.Parse("1984-05-28"),Address="52 Mainstreet,Ongar",Education="Degree",ContactNumber=0832280482},
            };

            students.ForEach(s => context.Students.Add(s));
            context.SaveChanges();
            var courses = new List<Course>
            {
             new Course{CourseID="121",scheduleIn=DateTime.Parse("2017-06-01"),scheduleEnd=DateTime.Parse("2017-08-03"),cardNo="3424567890123456" ,ExpiresDate=DateTime.Parse("2020-10-01"),CardName="Navin",CVN=123},
             new Course{CourseID="139",scheduleIn=DateTime.Parse("2017-06-20"),scheduleEnd=DateTime.Parse("2017-08-14"),cardNo="9874567890123451" ,ExpiresDate=DateTime.Parse("2018-03-01"),CardName="Raman",CVN=989},
            new Course { CourseID="156",scheduleIn=DateTime.Parse("2017-06-30"),scheduleEnd=DateTime.Parse("2017-08-28"),cardNo="3214567890123458" ,ExpiresDate=DateTime.Parse("2019-04-01"),CardName="Selvi",CVN=189},




            };
            courses.ForEach(s => context.Courses.Add(s));
            context.SaveChanges();
            var enrollments = new List<Enrollment>
            {
            new Enrollment{EnrollmentID="X123", StudentID="123",CourseID="121",Grade=Grade.A},
            new Enrollment{EnrollmentID="X124", StudentID="131",CourseID="139",Grade=Grade.C},
            new Enrollment{EnrollmentID="X125", StudentID="127",CourseID="156",Grade=Grade.B},
            new Enrollment{EnrollmentID="X126", StudentID="127",CourseID="121",Grade=Grade.B},
            new Enrollment{EnrollmentID="X127", StudentID="124",CourseID="139",Grade=Grade.F},
            new Enrollment{EnrollmentID="X128", StudentID="130",CourseID="156",Grade=Grade.F},
            new Enrollment{EnrollmentID="X129", StudentID="128",CourseID="121", Grade=Grade.B},
            new Enrollment{EnrollmentID="X130", StudentID="129",CourseID="139", Grade=Grade.C},
            new Enrollment{EnrollmentID="X131", StudentID="128",CourseID="156",Grade=Grade.F},
            new Enrollment{EnrollmentID="X132", StudentID="130",CourseID="121",Grade=Grade.C},
            new Enrollment{EnrollmentID="X133", StudentID="125",CourseID="139", Grade=Grade.F},
            new Enrollment{EnrollmentID="X134", StudentID="125",CourseID="156",Grade=Grade.A},
            };
            enrollments.ForEach(s => context.Enrollments.Add(s));
            context.SaveChanges();
        }
    }
}