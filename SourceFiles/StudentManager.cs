using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradingSystemApplication
{
    class StudentManager
    {
        public void ProcessGrade(Student student, EffectPercentageOfGrade effectPercentageOfGrade)
        {
            CalculateTotalGrade(student, effectPercentageOfGrade);
            SetLetterGrade(student);
        }

        public float CalculateTotalGrade(Student student, EffectPercentageOfGrade effectPercentageOfGrade)
        {
            student.TotalGrade = student.Homework1 * effectPercentageOfGrade.EffectPercentageOfHomework1 +
                                 student.Homework2 * effectPercentageOfGrade.EffectPercentageOfHomework2 +
                                 student.Project * effectPercentageOfGrade.EffectPercentageOfProject +
                                 student.MidtermExam * effectPercentageOfGrade.EffectPercentageOfMidtermExam +
                                 student.FinalExam * effectPercentageOfGrade.EffectPercentageOfFinalExam;

            return student.TotalGrade;
        }

        public string SetLetterGrade(Student student)
        {
            student.LetterGrade = CheckLetterGrade(student.TotalGrade);
            return student.LetterGrade;
        }

        public string CheckLetterGrade(float totalGrade)
        {
            string letterGrade = null;

            //The letter grade equivalents of the points are determined.
            if (totalGrade >= 90 && totalGrade <= 100)
            {
                letterGrade = "AA";
            }
            else if (totalGrade >= 85 && totalGrade < 90)
            {
                letterGrade = "BA";
            }
            else if (totalGrade >= 80 && totalGrade < 85)
            {
                letterGrade = "BB";
            }
            else if (totalGrade >= 75 && totalGrade < 80)
            {
                letterGrade = "CB";
            }
            else if (totalGrade >= 65 && totalGrade < 75)
            {
                letterGrade = "CC";
            }
            else if (totalGrade >= 58 && totalGrade < 65)
            {
                letterGrade = "DC";
            }
            else if (totalGrade >= 50 && totalGrade < 58)
            {
                letterGrade = "DD";
            }
            else if (totalGrade >= 40 && totalGrade < 50)
            {
                letterGrade = "FD";
            }
            else if (totalGrade >= 0 && totalGrade < 40)
            {
                letterGrade = "FF";
            }

            return letterGrade;
        }
    }
}
