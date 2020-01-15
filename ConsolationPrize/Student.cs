using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolationPrize
{
    class Student
    {
        public int StudentID { get; set; }
        /// <summary>
        /// First and last name of student
        /// </summary>
        public string FullName { get; set; }
        /// <summary>
        /// The date the student was born; Time is ignored
        /// </summary>
        public DateTime? DateOfBirth { get; set; }
        /// <summary>
        /// The Courses the student is enrolled in
        /// </summary>
        public List<Course> Courses { get; set; }
    }
}
