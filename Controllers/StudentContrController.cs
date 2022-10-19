using MVCdatabaseConnection.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCdatabaseConnection.Controllers
{
    public class StudentContrController : Controller
    {
        // GET: StudentContr

        private readonly ApplicationContext context;

        public StudentContrController()
        {
            context = new ApplicationContext();
        }
        public ViewResult Index()
        {
            var studentList = context.Students.ToList();
            studentList.Add(new Student {  Name = "Firoj", Class = "BCA", Subject = "Computer Fundamentals" });
            studentList.Add(new Student { Id = 102, Name = "Rahul", Class = "BCA", Subject = "Computer Networks" });
            studentList.Add(new Student { Id = 103, Name = "Vikram", Class = "BCA", Subject = "C Language" });
            studentList.Add(new Student { Id = 104, Name = "Jitender", Class = "BCA", Subject = "Web Desigining" });
            studentList.Add(new Student { Id = 105, Name = "Sonu", Class = "BCA", Subject = "Codding with C++" });
            studentList.Add(new Student { Id = 106, Name = "Ashok", Class = "BCA", Subject = "Linux" });
            return View(studentList);
        }
    }
}