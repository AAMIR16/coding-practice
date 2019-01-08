using System;
using System.Collections.Generic;
using System.Text;


namespace MethodsExercises
{
    class Factorial
    {
        public static ulong Factnumber(ulong numberz, out ulong result)
        {
            ulong mul = 1;
            for (ulong i = 1; i < numberz; i++)
            {
                mul = mul * (i + 1);
            }

            result = mul;
            return result;

        }

        public static int Fact(int num)
        {
            if (num == 0)
                return 1;
            else
                return num * (Fact(num -1));

        }

        private string Name;

        

    }
}
