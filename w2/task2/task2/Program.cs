using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace task2{
    class Program{
        public static bool Is_Prime(int a){//function to check if number is prime
            if (a == 1)
                return false;
            for (int i = 2; i <= a / 2; i++){
                if (a % i == 0)
                    return false;
            }
            return true;
        }
        static void Main(string[] args){
            int a;
            string s = System.IO.File.ReadAllText(@"..\..\..\input.txt");//converts everything in to string
            System.IO.File.WriteAllText(@"..\..\..\output.txt", "");//creates new file for output
            string[] sa = s.Split(' '); //splits string to an array of string numbers("26")
            for (int i = 0; i < sa.Length; i++){
                a = int.Parse(sa[i]);//from int to string
                if (Is_Prime(a))//prime function
                    System.IO.File.AppendAllText(@"..\..\..\output.txt", a + " ");//if prime is true then it fills it to output
            }
            Console.ReadKey();

        }
    }
}