using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolationPrize
{
    class Course
    {
        /// <summary>
        /// Title of the course, as it appears in the course class schedule
        /// </summary>
        public string CourseTitle { get; set; }
        /// <summary>
        /// Text description of the course (as appears in the course class schedule)
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// The unique course ID assigned to each course
        /// </summary>
        public int CourseID { get; set; }
        /// <summary>
        /// How many credits earned upon completion of the course
        /// </summary>
        public byte Credits { get; set; }

    }
}
