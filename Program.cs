using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradingSystemApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            string fileToRead = @"..\Debug\Files\InputFiles\StudentInformation.txt";
            string fileToWrite = @"..\Debug\Files\OutputFiles\ClassStatistics.txt";

            FileProcessing fileProcessing = new FileProcessing();
            fileProcessing.ReadFile(fileToRead);
            fileProcessing.WriteFile(fileToWrite);

            Console.WriteLine("Class statistics completed. Press any key to exit.");
            Console.ReadKey();
        }
    }
}
