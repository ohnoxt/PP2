using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3
{
    class idontseeanythingbiggerthandauren
    {
        static void Main(string[] args)
        {
            
            int ohnono = Convert.ToInt32(Console.ReadLine());//convert string from console to int
            string[] fat = Console.ReadLine().Split(); //reads string from console and splits it by spaces
            for (int i = 0; i < ohnono; i++)
            {
                int temp = int.Parse(fat[i]);//convert type from string to int 
                for (int j = 1; j <= 2; j++)
                {
                    Console.Write(temp + " ");//==cout
                }
            }
        }
    }
}