using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradingSystemApplication
{
    class FileProcessing
    {
        List<string> lines = new List<string>();
        List<Student> students = new List<Student>();
        List<string> classLetterGrades = new List<string>();

        public void ReadFile(string fileToRead)
        {
            lines = File.ReadAllLines(fileToRead).ToList();

            EffectPercentageOfGrade effectPercentageOfGrade = new EffectPercentageOfGrade();

            int thLine = 0;
            foreach (string line in lines)
            {
                ValidateLine(thLine, line, effectPercentageOfGrade);
                thLine++;
            }


            StudentManager studentManager = new StudentManager();
            foreach (Student student in students)
            {
                studentManager.ProcessGrade(student, effectPercentageOfGrade);
            }
        }

        public void WriteFile(string fileToWrite)
        {
            ClassStatisticsInformation classStatisticsInformation = new ClassStatisticsInformation();
            ClassStatisticsInformationManager classStatisticsInformationManager = new ClassStatisticsInformationManager();
            foreach (Student student in students)
            {
                classStatisticsInformationManager.CalculateTotalStudents(classStatisticsInformation);
                classStatisticsInformationManager.CreateClassStatistics(student, classStatisticsInformation);
            }
            classLetterGrades.Add(classStatisticsInformation.ToString());
            File.WriteAllLines(fileToWrite, classLetterGrades);
        }

        public void ValidateLine(int thLine, string line, EffectPercentageOfGrade effectPercentageOfGrade)
        {
            //Grade Impact Percentages and Student Information are distinguished by the line number.
            if (thLine >= 0 && thLine <= 4)
            {
                string[] percentages = line.Split(':');

                if (thLine == 0)
                {
                    effectPercentageOfGrade.EffectPercentageOfHomework1 = Convert.ToSingle(percentages[1]);
                }
                else if (thLine == 1)
                {
                    effectPercentageOfGrade.EffectPercentageOfHomework2 = Convert.ToSingle(percentages[1]);
                }
                else if (thLine == 2)
                {
                    effectPercentageOfGrade.EffectPercentageOfProject = Convert.ToSingle(percentages[1]);
                }
                else if (thLine == 3)
                {
                    effectPercentageOfGrade.EffectPercentageOfMidtermExam = Convert.ToSingle(percentages[1]);
                }
                else if (thLine == 4)
                {
                    effectPercentageOfGrade.EffectPercentageOfFinalExam = Convert.ToSingle(percentages[1]);
                }
            }
            else
            {
                string[] items = line.Split(',');
                Student student = new Student
                {
                    StudentID = items[0],
                    FirstName = items[1],
                    LastName = items[2],
                    Homework1 = Convert.ToInt32(items[3]),
                    Homework2 = Convert.ToInt32(items[4]),
                    Project = Convert.ToInt32(items[5]),
                    MidtermExam = Convert.ToInt32(items[6]),
                    FinalExam = Convert.ToInt32(items[7])
                };
                students.Add(student);
            }
        }
    }
}
