using System;

namespace HelloWorldApp
{
    class Program
    {
        static void Main(string[] args)
        {
            #region task1
            static int FindCharIndex()
            {
                Console.WriteLine("Enter a string:");
                string input_string = Console.ReadLine();
                Console.WriteLine("Enter a char:");

                string input_char = Console.ReadLine();

                while (input_char.Length != 1)
                {
                    Console.WriteLine("Ancaq bir char daxil edin.");
                    input_char = Console.ReadLine();
                }

                for (int i = 0; i < input_string.Length; i++)
                {
                    if (input_string[i] == input_char[0])
                    {
                        return i;
                    }
                }
                return -1;
            }
            #endregion
            #region IsPrime
            static bool IsPrime(int n)
            {
                if (n < 2)
                {
                    return false;
                }
                int count = 0;

                for (int i = 2; i < n; i++)
                {
                    if (n % i == 0)
                    {
                        count++;
                    }
                }

                if (count > 0)
                {
                    return false;
                }
                return true;
            }
            #endregion

            #region CalcAvg
            static int CalcAvg(int[] array)
            {
                int sum = 0;

                for (int i = 0; i < array.Length; i++)
                {
                    sum += array[i];
                }

                return sum / array.Length;              
            }

            int[] arr = { 90, 32, 50, 90 };
            
            if (CalcAvg(arr) > 60)
            {
                Console.WriteLine("Mezun oldunuz.");
            } 
            else
            {
                Console.WriteLine("Mezun olmadiniz.");
            }
            #endregion
        }
    }
}