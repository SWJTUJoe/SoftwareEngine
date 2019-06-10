using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 上机实习二
{
    class Forward_Inter : Abstract_Crocal
    {
        public override Data Cross_Cal(Data p1, Data p2, Data A, Data B)
        {
            Data resultP = new Data();
            resultP.x = (p1.x * Math.Tan(Math.PI / 2 - Base_Calculation.function5(B)) + p2.x * Math.Tan(Math.PI / 2 - Base_Calculation.function5(A)) - p1.y + p2.y) / (Math.Tan(Math.PI / 2 - Base_Calculation.function5(B)) + Math.Tan(Math.PI / 2 - Base_Calculation.function5(A)));
            resultP.y = (p1.y * Math.Tan(Math.PI / 2 - Base_Calculation.function5(B)) + p2.y * Math.Tan(Math.PI / 2 - Base_Calculation.function5(A)) + p1.x - p2.x) / (Math.Tan(Math.PI / 2 - Base_Calculation.function5(B)) + Math.Tan(Math.PI / 2 - Base_Calculation.function5(A)));
            return resultP;
        }
    } 
}
