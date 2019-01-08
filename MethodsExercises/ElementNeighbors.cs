using System;
using System.Collections.Generic;
using System.Text;

namespace MethodsExercises
{
    public class ElementNeighbors
    {
        public static void Elements(int position, int[] elements)
        {
          if((elements[position - 1] < elements[position]) && (elements[position + 1] < elements[position]))
            {
                Console.WriteLine("The element in position {0} in the array is {1} is greater than {2} and {3} ",position, elements[position], elements[position - 1], elements[position + 1]);
            }
          else
                Console.WriteLine("The element in position {0} is not greater than the number {1}", position, elements[position]);
        }

    }
}
