using System;
using System.Collections.Concurrent;
using System.IO;

namespace MethodsExercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            Thousandtotho();
            UpByThrees();
            int x = 10;
            int y = 5;
            TheyEqual(x, y);
            int a = 43;
            IsItEven(a);
            Console.WriteLine("How old are you?");
            OldEnough(int.Parse(Console.ReadLine()));
            int v = -22;
            OddOrEven(v);
            int r = -12;
            TentoTen(r);
            TimesTwelve(12);
            var newarray = ArrayRando(8);
            foreach (var number in newarray)
            {
                Console.WriteLine(number);
            }
            ArrayAdd(2);
            Console.WriteLine("Give me a number");

            IntCubed(int.Parse(Console.ReadLine()));

        }
        public static void Thousandtotho()
        {
            for (int i = 1000; i >= -1000; i--)
            {
                Console.WriteLine($"{i}");

            }

        }

        public static void UpByThrees()
        {
            for (int i = 0; i <= 999; i += 3)
            {
                Console.WriteLine($"{i}");
            }
        }

        public static void TheyEqual(int x, int y)
        {
            {

                if (x == y)
                {

                    Console.WriteLine("They are equal");
                }
                else
                {
                    Console.WriteLine("They are not equal");
                }


            }

        }

        public static void IsItEven(int a)
        {
            if (a % 2 == 0)
            {
                Console.WriteLine("Hey this is an even number!");
            }
            else
            {
                Console.WriteLine("Hey this isn't an even number!");
            }
        }

        public static void OddOrEven(int v)
        {
            if (v > 0)
            {
                Console.WriteLine("Its even!");
            }
            else
            {
                Console.WriteLine("Its odd");
            }
        }

        public static void OldEnough(int c)
        {
            if (c >= 18)
            {
                Console.WriteLine("You're old enough to vote!");
            }
            else
            {
                Console.WriteLine("Sorry my guy, cant snoke, cant vote!");
            }
        }

        public static void TentoTen(int r)
        {
            if (r >= -10 && r <= 10)
            {
                Console.WriteLine("You're within the paramater");
            }
            else
            {
                Console.WriteLine("You're outside the paramater!");
            }
        }

        public static void TimesTwelve(int dad)
        {
            for (int f = 1; f <= dad; f++)
            {
                var num1 = f * 12;
                

                Console.WriteLine($"{num1}");
            }

        }
        public static int [] ArrayRando(int b)
        {
            var array = new int[b];
                var random = new Random();
            for (int a = 0; a < array.Length; a++)
            {
                array[a] = random.Next(1, 100);
            }
            return array;
        }
        public static void ArrayAdd(int sums)
        {
            int[] nums = { 1, 3, 4, 6, 2, 4, 2, 45, 2, 1 };

            for (var i = 0; i < nums.Length; i++)
            {
                sums += nums[i];
            }
        }
        public static void IntCubed(int cubeTo)
        {
            int cubed = 0;
            for(int i = 1; i <= cubeTo; i++)
            {
                 cubed = (int)Math.Pow(i, 3);
                Console.WriteLine($"Number is: {i}, and the cube of {i}, is {cubed}");
            }
        }
    }
}
