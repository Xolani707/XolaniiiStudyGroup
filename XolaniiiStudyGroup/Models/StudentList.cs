using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace XolaniiiStudyGroup.Models
{
	public class StudentList
	{
        [DisplayName("Student Number")]
        public string StudentNumber { get; set; }

        [DisplayName("Name")]
        public string Name { get; set; }

        [DisplayName("Surname")]
        public string Surname { get; set; }

        [DisplayName("Email Address")]
        public string EmailAddress { get; set; }
    }
}