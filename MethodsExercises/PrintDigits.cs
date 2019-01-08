using System;
using System.Collections.Generic;
using System.Text;

namespace MethodsExercises
{
    class PrintDigits
    {
        public static string ExtractDecimal(string decimalnumber)
        {
            char dot = '.';
            return (decimalnumber.Trim(dot));
        }

        public static void BreakDecimal(string number)
        {
            List<int> sepNum = new List<int>();

            for (int i = 0; i < number.Length; i++)
            {
                Convert.ToInt32(number);
                //int remainder = number % 10;

            }
            
            //sepNum.Add(remainder);

        }
    }
}
