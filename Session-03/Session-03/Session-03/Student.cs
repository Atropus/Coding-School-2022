using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_03
{
    internal class Students : Person
    {
        public int RegistrationNumber { get; set; }

        public Course[] Course { get; set; }

        public void Attend(Course course, DateTime dateTime)
        {

        }
        public void WriteExam(Course course, DateTime dateTime)
        {

        }
    }
}
