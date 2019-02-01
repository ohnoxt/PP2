using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task4
{
    class lookatthisdude
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()); //creating size of array
            int[,] r = new int[n, n]; //array is 2D so it has n rows and n columns
            for (int i = 0; i < n; i++) //made for [i] elements(rows)
            {
                for (int j = 0; j <= i; j++) //made for [j] elements, but because of the fact that columns bigger than rows for 1 element it reaches to the [i] element 
                {
                    Console.Write("[*]"); //==cout
                }
                Console.WriteLine(); //end of the line for the current line
            }
        }
    }
}
