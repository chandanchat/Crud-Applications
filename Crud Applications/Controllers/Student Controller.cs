using Crud_Applications.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Crud_Applications.Controllers
{
    public class Student_Controller : Controller
    {
        StudentDbContext db;
        public Student_Controller(StudentDbContext context)
        {
            db = context; 
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult create(Student ampob)
        {
            db.Students.Add(ampob);
            db.SaveChanges();
            return View();
        }
    }
}
