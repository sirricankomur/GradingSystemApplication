using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradingSystemApplication
{
    class EffectPercentageOfGrade
    {
        public float EffectPercentageOfHomework1 { get; set; }
        public float EffectPercentageOfHomework2 { get; set; }
        public float EffectPercentageOfProject { get; set; }
        public float EffectPercentageOfMidtermExam { get; set; }
        public float EffectPercentageOfFinalExam { get; set; }

        public override string ToString()
        {
            return Convert.ToString(EffectPercentageOfHomework1) + Convert.ToString(EffectPercentageOfHomework2) +
                   Convert.ToString(EffectPercentageOfProject) + Convert.ToString(EffectPercentageOfMidtermExam) +
                   Convert.ToString(EffectPercentageOfFinalExam);
        }
    }
}
