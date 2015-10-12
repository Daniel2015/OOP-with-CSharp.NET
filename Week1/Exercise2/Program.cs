/*
Problem No. 2
Implement the method Find-median.The function find-median accepts
three irregular values as formal parameters and returns the median
of the three numbers. The median of three numbers is the number 
that is greater than one of the numbers and less than the other 
number. The median of 10, 30 and 20 is 20. The median of 5, 5 and 5 is 5.
The median of 12, 20 and 12 is 12. A call to find-median will take the form:
median = Find-median(num1,num2,num3);
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2
{
    class Exercise2
    {
        public static int FindMedian(int num1, int num2, int num3) //Method accepting three values and returning the median of them three
        {
            //If both multipliers are positive, then num1 >= num2 AND num3 >= num1 so num3 >= num1 >= num2
            //If both multipliers are negative, then num2 >= num1 AND num1 >= num3 so num2 >= num1 >= num3
            if ((num1 - num2) * (num3 - num1) >= 0)
            {
                return num1;
            }
            //If both multipliers are positive, then num2 >= num1 and num3 >= num2 so num3 >= num2 >= num1
            //If both multipliers are negative, then num1 >= num2 and num2 >= num3 so num1 >= num2 >= num3
            else if ((num2 - num1) * (num3 - num2) >= 0)
            {
                return num2;
            }
            //If num1 or num2 is not a median, then num3 must be
            else
            {
                return num3;
            }
        }
        static void Main(string[] args)
        {
            int median = FindMedian(12,20,12); //Find median of three numbers: 12, 20 and 12
            Console.WriteLine(median); //Print the result of FindMedian
        }
    }
}
