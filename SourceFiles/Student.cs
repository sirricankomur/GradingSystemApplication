using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradingSystemApplication
{
    class Student
    {
        public string StudentID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public float Homework1 { get; set; }
        public float Homework2 { get; set; }
        public float Project { get; set; }
        public float MidtermExam { get; set; }
        public float FinalExam { get; set; }
        public float TotalGrade { get; set; }
        public string LetterGrade { get; set; }

        public override string ToString()
        {
            return FirstName + LastName + StudentID + Convert.ToString(Homework1) + Convert.ToString(Homework2) + Convert.ToString(MidtermExam) + Convert.ToString(FinalExam);
        }
    }
}
