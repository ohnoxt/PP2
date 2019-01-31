using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    class Program
    {
        public static bool Prime(int ohno) // it is a bool function with public class
        {
            if (ohno == 1) // 1 is not a prime number
                return false;
            for (int i = 2; i <= Math.Sqrt(ohno); i++)
            {
                if (ohno % i == 0)// because of the property of the prime numbers it can't be divided by "i", so then if it does it returns false 
                    return false;
            }
            return true;//that's our prime
        }
        static void Main(string[] args)
        {
            int n, cnt = 0; // simple integers like in cpp
            n = Convert.ToInt32(Console.ReadLine()); // that function helps to converts string into numbers, because int isn't string
            int[] RT = new int[n];//new array
            int[] RTS = new int[6666];// new array
            string[] RTSS = new string[100];// new array
            RTSS = Console.ReadLine().Split();//deletes all namespaces

            for (int i = 0; i < n; i++)
            {
                RT[i] = int.Parse(RTSS[i]);// almost the same function as 'Convert.ToInt32(Console.ReadLine())' it also converts from string to int

                if (Prime(RT[i]))// calling prime bool function
                {
                    cnt++;
                }
            }
            Console.WriteLine(cnt); // == cout

            for (int i = 0; i < RT.Count(); i++)
            {
                if (Prime(RT[i])) // calling prime bool function
                {
                    Console.Write(RT[i] + " "); // == cout
                }
            }

        }
    }