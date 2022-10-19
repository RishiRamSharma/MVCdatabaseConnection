using MVCdatabaseConnection.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCdatabaseConnection.Controllers
{
    public class FacultyCtlController : Controller
    {
        // GET: FacultyCtl

        private readonly ApplicationContext context;
        public FacultyCtlController()
        {
            context = new ApplicationContext();
        }
        public ViewResult Index()
        {
            var facultylist = context.Faculties.ToList();
                    
            facultylist.Add(new Faculty { Id = 201, Name = "Neeraj Sahu", Class = "BCA", Subject = "Computer Networks" });
            facultylist.Add(new Faculty { Id = 202, Name = "Swati Gupta", Class = "BCA", Subject = "Linux" });
            facultylist.Add(new Faculty { Id = 203, Name = "Naveen Kundu", Class = "BCA", Subject = "Computer Fundamentals" });
            facultylist.Add(new Faculty { Id = 204, Name = "Suman Sharma", Class = "BCA", Subject = "Codding with C++" });
            facultylist.Add(new Faculty { Id = 205, Name = "Seema Dhanda", Class = "BCA", Subject = "C Language" });

            return View(facultylist);
        }
    }
}