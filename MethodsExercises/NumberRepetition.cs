using System;
using System.Collections.Generic;
using System.Text;

namespace MethodsExercises
{
    class NumberRepetition
    {
        public static void NumberRep(int samplenumber, params int[] numbers)
        {
            int count = 0;

            foreach (int numbersInArray in numbers)
            {
                if (numbersInArray == samplenumber)
                {
                    count++;
                }
            }
            Console.WriteLine("Total repetitions of {0} are {1} ", samplenumber, count);
        }
    }
}
