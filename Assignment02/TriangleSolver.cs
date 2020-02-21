using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment02
{
    public static class TriangleSolver
    {
        public static String Analyze(int firstDimension, int secondDimension, int thirdDimension)
        {
            String result;
            
            if(firstDimension + secondDimension <= thirdDimension && firstDimension + thirdDimension <= secondDimension && secondDimension + thirdDimension <= firstDimension)
            {
                result = "Triangle not formed";
            }
            else
            {
                if (firstDimension == secondDimension && secondDimension == thirdDimension)
                {
                    result = "It's a equilateral triangle";
                }
                else if (firstDimension == secondDimension || firstDimension == thirdDimension || secondDimension == thirdDimension)
                {
                    result = "It's a isoceles triangle";
                }
                else
                {
                    result = "It's a scalene triangle";
                }
            }
            return result;
        }
    }
}
