 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 上机实习二
{
    class Dis_Rendezvous:Forward_Inter
    {
        public override Data Cross_Cal(Data p1, Data p2, Data L1, Data L2)
        {
            double A,L;
            Data Result_P = new Data();         
            L = Base_Calculation.Distance(p1, p2);
            A = Base_Calculation.Angle_cal(p1, p2) - Math.Acos((L * L + L1.Distance * L1.Distance - L2.Distance * L2.Distance) / (2 * L * L1.Distance));
            Result_P.x= p1.x + L1.Distance * Math.Cos(A);
            Result_P.y= p1.y + L1.Distance * Math.Sin(A);
            return Result_P;
        }
    }
}
