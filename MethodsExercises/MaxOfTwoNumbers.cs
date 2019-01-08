using System;
using System.Collections.Generic;
using System.Text;

namespace MethodsExercises
{
    class MaxOfTwoNumbers
    {
        public static void GetMax(int num1, int num2)
        {
            int result = Math.Max(num1, num2);
            Console.WriteLine("The biggest is: " +result);


            //if(num1 > num2)
            //    Console.WriteLine("The biggest number is: " +num1);
            //else if(num1<num2)
            //    Console.WriteLine("The biggest number is: "+num2);
            //else
            //    Console.WriteLine("They both are equal:" +num1);
        }
    }
}
