using System;
using System.Collections.Generic;
using System.Text;

namespace MethodsExercises
{
    class FirstOccurence
    {
        public static int Elements(int[] elements)
        {
            //int result = 0;

            for (int i = 1; i < elements.Length - 1; i++)
            {

                if (elements[i - 1] < elements[i] && elements[i + 1] < elements[i])
                {
                    //result = i;
                    //return result;
                    return i;

                    //Console.WriteLine("The first occuerence is " + result);
                }
            }
            //if (result == 0) Console.WriteLine("-1");
            return -1;









        }
    }
}
