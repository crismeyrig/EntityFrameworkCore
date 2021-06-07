using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EntityFrameworkCore.DAL
{
    public class Course
    {
        public object Teacher { get; internal set; }
        public object CourseName { get; internal set; }
    }
}
