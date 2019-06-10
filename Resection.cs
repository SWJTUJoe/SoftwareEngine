using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 上机实习二
{
    class Resection: Abstract_Crocal1
    {
        public override Data Cross_Cal1(Data p1, Data p2, Data p3,Data A, Data B,Data C)
        {
            Data Result_P = new Data();
            double A1, B1,C1,Pa,Pb,Pc;
            A1 = Base_Calculation.Angle_cal(p1,p3) - Base_Calculation .Angle_cal(p1,p2);
            B1 = Base_Calculation.Angle_cal (p2 ,p1) - Base_Calculation .Angle_cal(p2,p3);
            C1 = Base_Calculation .Angle_cal (p3,p2) - Base_Calculation.Angle_cal(p3,p1);
            Pa = Math.Sin(Base_Calculation.function5(A)) * Math.Sin(A1) / (Math.Cos(Base_Calculation.function5(A)) * Math.Sin(A1) - Math.Cos(A1) * Math.Sin(Base_Calculation.function5(A)));
            Pb = Math.Sin(Base_Calculation.function5(B)) * Math.Sin(B1) / (Math.Cos(Base_Calculation.function5(B)) * Math.Sin(B1) - Math.Cos(B1) * Math.Sin(Base_Calculation.function5(B)));
            Pc = Math.Sin(Base_Calculation.function5(C)) * Math.Sin(C1) / (Math.Cos(Base_Calculation.function5(C)) * Math.Sin(C1) - Math.Cos(C1) * Math.Sin(Base_Calculation.function5(C)));
            Result_P.x= (Pa * p1.x + Pb * p2.x + Pc * p3.x) / (Pa + Pb + Pc);
            Result_P.y= (Pa * p1.y + Pb * p2.y + Pc * p3.y) / (Pa + Pb + Pc);           
            return Result_P; 
        }
    }
}
