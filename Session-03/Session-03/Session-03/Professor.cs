using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_03
{
    public class Professor : Person
    {
        public string Rank { get; set; }

        public void Teach(Course course, DateTime date)
        { 
        
        }

        public void SetGrade(Guid studenId, Guid courseId, int grade)
        {

        }

        public new string GetName()
        {
            return "Dr. " + Name;

        }
    }
}