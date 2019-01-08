using System;
using System.Collections.Generic;
using System.Text;

namespace MethodsExercises
{
    class ReverseSort
    {
        public static void ReverseArray(params int[] number)
        {


            foreach(int j in number)
            {
                Console.Write("The numbers are: " +j);

            }
            var max = int.MinValue;
            foreach (var num in number)
            {
                if (num > max)
                    max = num;
            }
            System.Console.WriteLine("The largest number in an array is : " +max);
            Array.Sort(number);
            Array.Reverse(number);
            foreach (int i in number)
            {
                Console.WriteLine("After reverse sort, the numbers are {0}: ", i);

            }
        }

        public static void ReverseOrder()
        {
            //string number = "12345";  // Can i create an array or list with size 1 and have an int input? 
            //List<int> each = new List<int>();
            //for(int i = 0; i< number.Length; i++)
            //{
            //  each[i] = Convert.ToInt32(number) % 10;
            //}

            //foreach(int j in each)
            //    Console.WriteLine(j);

            decimal n = 1.12m;

            
            string answer = "";

            while(n != 0)
            {
                Console.WriteLine("n = " +n);
                answer += (n % 10).ToString();
                Console.WriteLine("answer = "+answer);
                n /= 10;
            }

            Console.WriteLine(answer);
            Console.ReadLine();

        }
    }
}
