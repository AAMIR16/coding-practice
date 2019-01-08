using System;
using System.Collections.Generic;
using System.Text;

namespace MethodsExercises
{
    public class Sequence
    {

        public static void Menu()
        {
            Console.WriteLine("Please enter your choice: \n 1: Digits in reverse order \n 2: Avg of numbers \n 3: Linear equation");
            int menu = Convert.ToInt32(Console.ReadLine());
            switch (menu)
            {
                case 1:
                    Console.WriteLine("Not yet implemented");
                    break;
                case 2:
                    List<int> nums = new List<int>() { 2, 3, 4, 5, 6, 40 };

                    Average(nums, out int output);
                    Console.WriteLine("The average is:" + output);
                    break;
                case 3: LinearEquation(Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()), out int res);
                    Console.WriteLine("the value is {0}", res);
                    break;
                default:
                    Console.WriteLine("Please enter your choice:");
                    break;

            }
        }
        public static int Average(List<int> n, out int result)
        {
            int total = 0;

            foreach (int i in n)
            {
                total += i;
            }
            result = total / n.Count;
            return result;

        }

        public static int LinearEquation(int a, int b, out int x)
        {
            if (a > 0)
            {
                x = -(b) / a;
                Console.WriteLine("The linear equation is ax+b=0. i.e {0} x + {1} = 0", a, b);
                return x;
            }
            else
                return x = 0;
            
               
        }
    }
}
