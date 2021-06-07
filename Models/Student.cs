using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EntityFrameworkCore.Models
{
     class Student
     {
        public object FirstName { get; internal set; }

        public partial class Student
        {
            public Student() => StudentCourse = new HashSet<StudentCourse>();

            public int StudentId { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public int? StandardId { get; set; }

            public Standard Standard { get; set; }
            public StudentAddress StudentAddress { get; set; }
            public ICollection<StudentCourse> StudentCourse { get; set; }

        }
    }
}
