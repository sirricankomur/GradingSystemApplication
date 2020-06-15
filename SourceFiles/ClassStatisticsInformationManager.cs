using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradingSystemApplication
{
    class ClassStatisticsInformationManager
    {
        public void CalculateThePercentageOfSuccess(ClassStatisticsInformation classStatisticsInformation)
        {
            classStatisticsInformation.PercentageOfAA = classStatisticsInformation.TotalAA / classStatisticsInformation.TotalStundets;
            classStatisticsInformation.PercentageOfBA = classStatisticsInformation.TotalBA / classStatisticsInformation.TotalStundets;
            classStatisticsInformation.PercentageOfBB = classStatisticsInformation.TotalBB / classStatisticsInformation.TotalStundets;
            classStatisticsInformation.PercentageOfCB = classStatisticsInformation.TotalCB / classStatisticsInformation.TotalStundets;
            classStatisticsInformation.PercentageOfCC = classStatisticsInformation.TotalCC / classStatisticsInformation.TotalStundets;
            classStatisticsInformation.PercentageOfDC = classStatisticsInformation.TotalDC / classStatisticsInformation.TotalStundets;
            classStatisticsInformation.PercentageOfDD = classStatisticsInformation.TotalDD / classStatisticsInformation.TotalStundets;
            classStatisticsInformation.PercentageOfFD = classStatisticsInformation.TotalFD / classStatisticsInformation.TotalStundets;
            classStatisticsInformation.PercentageOfFF = classStatisticsInformation.TotalFF / classStatisticsInformation.TotalStundets;
        }

        public void CalculateTotalStudents(ClassStatisticsInformation classStatisticsInformation)
        {
            classStatisticsInformation.TotalStundets++;
        }

        public void ValidateLetterGrade(Student student, ClassStatisticsInformation classStatisticsInformation)
        {
            //The number of students who receive the letter grade is determined.
            if (student.LetterGrade == "AA")
            {
                classStatisticsInformation.TotalAA++;
            }
            else if (student.LetterGrade == "BA")
            {
                classStatisticsInformation.TotalBA++;
            }
            else if (student.LetterGrade == "BB")
            {
                classStatisticsInformation.TotalBB++;
            }
            else if (student.LetterGrade == "CB")
            {
                classStatisticsInformation.TotalCB++;
            }
            else if (student.LetterGrade == "CC")
            {
                classStatisticsInformation.TotalCC++;
            }
            else if (student.LetterGrade == "DC")
            {
                classStatisticsInformation.TotalDC++;
            }
            else if (student.LetterGrade == "DD")
            {
                classStatisticsInformation.TotalDD++;
            }
            else if (student.LetterGrade == "FD")
            {
                classStatisticsInformation.TotalFD++;
            }
            else if (student.LetterGrade == "FF")
            {
                classStatisticsInformation.TotalFF++;
            }
        }

        public void CreateClassStatistics(Student student, ClassStatisticsInformation classStatisticsInformation)
        {
            ValidateLetterGrade(student, classStatisticsInformation);
            CalculateThePercentageOfSuccess(classStatisticsInformation);
        }
    }
}
