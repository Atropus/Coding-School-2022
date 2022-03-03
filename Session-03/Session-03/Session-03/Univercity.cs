using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_03
{
    internal class University : Institude
    {
        public Students[] Students { get; set; }

        public Course[] Courses { get; set; }

        public Grade[] Grades { get; set; }

        public Schedule[] ScheduledCourses { get; set; }

        public Students[] GetStudents()
        {
           return Students;
        }
        public Course[] GetCourses()
        {
            return Courses;
        }

        public University()
        {
            Students = new Students[30];
            Courses = new Course[20];
            ScheduledCourses = new Schedule[60];
        }

        public void SetGrade(Guid studenId, Guid courseId, int grade)
        {

        }

    }
}

