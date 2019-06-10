using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 上机实习二
{
    class Base_Calculation
    {
        public static double function1(Data A)//弧度转十进制角度
        {

            return (A.Angle / Math.PI) * 180;
           
        }
        public static double function2(Data A)//十进制角度转弧度
        {

            return (A.Angle/ 180) * Math .PI;
            
        }
        public static double function3(Data A)//度分秒转十进制
        {         
            return A.Degree + (A.Minute / 60) + (A.Second / 3600); 
        }
        public static Data function4(Data A)//十进制转度分秒
        {           
            A.Degree = Math.Floor(A.Angle);
            A.Minute= Math.Floor((A.Angle - A.Degree) * 60);
            A.Second= ((A.Angle - A.Degree) * 60 -A.Minute) * 60;
            return A;
        }
        public static double function5(Data A)//度分秒转弧度
        {
            return ((A.Angle + A.Minute / 60 + A.Second / 3600) / 180) * Math.PI;
        }
        public static Data function6(Data A)//弧度转度分秒
        {           
            A.Angle = Base_Calculation.function1(A);
            A.Degree= Math.Floor(A.Angle);
            A.Minute= Math.Floor((A.Angle - A.Degree) * 60);
            A.Second= ((A.Angle - A.Degree) * 60 - A.Minute) * 60;         
            return A;
        }
        public static double Angle_cal(Data p1, Data p2)
        {//坐标方位角
            double A1, A;
            if (p2.y == p1.y && p2.x >p1.x) A1 = 0;
            else
            if (p2.y > p1.y && p2.x == p1.x) A1 = Math.PI/2;
            else if (p2.y < p1.y && p2.x == p1.y) A1 = Math.PI;
            else
            {
                A = Math.Atan((p2.y - p1.y) / (p2.x - p1.x));
                if (p2.y > p1.x && p2.x >p1.y) A1 = A;
                else if (p2.y > p1.y && p2.x < p1.x) A1 = A + Math.PI;
                else if (p2.y < p1.y && p2.x < p1.x) A1 = A + Math.PI;
                else if (p2.y <p1.y && p2.x > p1.x) A1 = A + 2 * Math.PI;
                else A1 = 0;
            }

            return A1;
        }
        public static double Distance(Data p1, Data p2)
        {
            return Math.Sqrt((p1.x - p2.x) * (p1.x - p2.x) + (p1.y - p2.y) * (p1.y - p2.y));
        }


    }
}
