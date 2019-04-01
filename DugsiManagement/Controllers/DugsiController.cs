using DugsiManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DugsiManagement.Controllers
{

    public class DugsiController : Controller
    {


        public ActionResult Index()
        {

            var students = new List<Student>() {
                new Student
                {
                    Id = 1,
                    FirstName = "Aisha",
                    LastName = "Abdi",
                    Gender = "Female",
                    Age = 3
                },
                new Student
                {
                    Id = 1,
                    FirstName = "Mucaad",
                    LastName = "Abdi",
                    Gender = "Male",
                    Age = 5
                },
                new Student()
                {
                    Id = 1,
                    FirstName = "Ali",
                    LastName = "Wali",
                    Gender = "Male",
                    Age = 3
                },
                new Student()
                {
                    Id = 1,
                    FirstName = "Fadumo",
                    LastName = "Nuur",
                    Gender = "Female",
                    Age = 40
                },
                new Student()
                {
                    Id = 1,
                    FirstName = "Shuri",
                    LastName = "Mohamed",
                    Gender = "Female",
                    Age = 6
                },
            };


            return View(students);
        }
    }
}