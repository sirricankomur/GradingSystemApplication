using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradingSystemApplication
{
    class ClassStatisticsInformation
    {
        public float TotalStundets { get; set; }
        public int TotalAA { get; set; }
        public int TotalBA { get; set; }
        public int TotalBB { get; set; }
        public int TotalCB { get; set; }
        public int TotalCC { get; set; }
        public int TotalDC { get; set; }
        public int TotalDD { get; set; }
        public int TotalFD { get; set; }
        public int TotalFF { get; set; }

        public float PercentageOfAA { get; set; }
        public float PercentageOfBA { get; set; }
        public float PercentageOfBB { get; set; }
        public float PercentageOfCB { get; set; }
        public float PercentageOfCC { get; set; }
        public float PercentageOfDC { get; set; }
        public float PercentageOfDD { get; set; }
        public float PercentageOfFD { get; set; }
        public float PercentageOfFF { get; set; }

        public override string ToString()
        {
            return "   -- GRADE STATISTICS OF THE CLASS --\n\n" +
                   "Total AA: " + TotalAA + "\tPercentage Of AA: " + PercentageOfAA * 100 +
                   "\nTotal BA: " + TotalBA + "\tPercentage Of BA: " + PercentageOfBA * 100 +
                   "\nTotal BB: " + TotalBB + "\tPercentage Of BB: " + PercentageOfBB * 100 +
                   "\nTotal CB: " + TotalCB + "\tPercentage Of CB: " + PercentageOfCB * 100 +
                   "\nTotal CC: " + TotalCC + "\tPercentage Of CC: " + PercentageOfCC * 100 +
                   "\nTotal DC: " + TotalDC + "\tPercentage Of DC: " + PercentageOfDC * 100 +
                   "\nTotal DD: " + TotalDD + "\tPercentage Of DD: " + PercentageOfDD * 100 +
                   "\nTotal FD: " + TotalFD + "\tPercentage Of FD: " + PercentageOfFD * 100 +
                   "\nTotal FF: " + TotalFF + "\tPercentage Of FF: " + PercentageOfFF * 100;
        }
    }
}
