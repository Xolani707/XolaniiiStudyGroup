using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using XolaniiiStudyGroup.Models;

namespace XolaniiiStudyGroup.Controllers
{
    public class StudentListController : Controller
    {
        // GET: StudentList
        public ActionResult StudyGroupList()
        {
            List<StudentList> students = new List<StudentList>
            {
               new StudentList
               {
                   StudentNumber = "u23533057",
                   Name = "Xolani",
                   Surname = "Tobo",
                   EmailAddress = "u23533057@tuks.co.za"
               },

                new StudentList
               {
                   StudentNumber = "u23552311",
                   Name = "Unathi",
                   Surname = "Mokgoetsi",
                   EmailAddress = "u23552311@tuks.co.za"
                },

                 new StudentList
               {
                   StudentNumber = "u22626752",
                   Name = "Sihle",
                   Surname = "Shange",
                   EmailAddress = "u22626752@tuks.co.za"
                 },

                  new StudentList
               {
                   StudentNumber = "u23534134",
                   Name = "Khensani",
                   Surname = "Nkwinika",
                   EmailAddress = "u23534134@tuks.co.za"
                  },

                   new StudentList
               {
                   StudentNumber = "u23583569",
                   Name = "Makgoshi",
                   Surname = "Mariri",
                   EmailAddress = "u23583569@tuks.co.za"
               },

            };

            return View(students);
        }
    }
}