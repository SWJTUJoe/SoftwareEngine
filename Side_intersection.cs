using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 上机实习二
{
    class Side_intersection:Abstract_Crocal
    {
        public override Data Cross_Cal(Data p1, Data p2, Data A, Data B)
        {
            Data Result_P = new Data();
            double C,L;double d = Base_Calculation.Angle_cal(p1, p2);
            C =  Math.PI - Base_Calculation.function5(A) - Base_Calculation.function5(B);
            L = (Math.Sin(Base_Calculation.function5(B)) * Base_Calculation.Distance(p1, p2)) / Math.Sin(C);
            Result_P.x = p1.x + L * Math.Cos(Base_Calculation.Angle_cal(p1, p2) - Base_Calculation.function5(A));
            Result_P.y = p1.y + L * Math.Sin(Base_Calculation.Angle_cal(p1, p2) - Base_Calculation.function5(A));
            return Result_P;
        }
    }
}
