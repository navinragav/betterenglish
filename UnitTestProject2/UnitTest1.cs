using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BetterEnglishWebApplication123.DAL;
using BetterEnglishWebApplication123.Models;
using BetterEnglishWebApplication123.Controllers;
using System.Web.Mvc;

namespace UnitTestProject2
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Student stu = new Student();
            stu.StudentID = "123";
            stu.FirstName = "Tim";
            stu.Date = DateTime.Parse("09/03/2017");
            stu.DOB = DateTime.Parse("11/23/1983");
            stu.Address = "33,Knocklyon view ,Knocklyon";
            stu.Education = "Degree";
            stu.ContactNumber = 0877801668;
            stu.Gender = Gender.Male;
            stu.LastName = "Shan";


            StudentsController sc = new StudentsController();
            var result = sc.Create(stu) as ViewResult;
            
        }
        [TestMethod]
        public void TestMethod2()
        {
            Student stu = new Student();
            stu.StudentID = "123";
            stu.FirstName = "Tim";
            stu.Date = DateTime.Parse("09/03/2017");
            stu.DOB = DateTime.Parse("11/23/1983");
            stu.Address = "33,Knocklyon view ,Knocklyon";
            stu.Education = "Degree";
            stu.ContactNumber = 0877801668;
            stu.Gender = Gender.Male;
            stu.LastName = "Shan";


            StudentsController sc = new StudentsController();
            var result = sc.Edit(stu) as ViewResult;

        }
        [TestMethod]
        public void TestMethod3()
        {
            Student stu = new Student();
            stu.StudentID = "123";
            stu.FirstName = "Tim";
            stu.Date = DateTime.Parse("09/03/2017");
            stu.DOB = DateTime.Parse("11/23/1983");
            stu.Address = "33,Knocklyon view ,Knocklyon";
            stu.Education = "Degree";
            stu.ContactNumber = 0877801668;
            stu.Gender = Gender.Male;
            stu.LastName = "Shan";


            StudentsController sc = new StudentsController();
            var result = sc.Detail(stu) as ViewResult;

        }
    }
    

    }


