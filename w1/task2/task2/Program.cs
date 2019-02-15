using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    class Student
    {
        public string name;//void function that calls printing
        public string id;
        public int year;

        public Student(string _name, string _id, int _year)
        {
            name = _name;
            id = _id;
            year = _year;
        }
        public void Print()
        {
            Console.WriteLine(name + " " + id + " " + year);
        }
    }
    class STOODENTY
    {
        static void Main(string[] args)
        {
            int y = 1;
            for (int i = 0; i < 4; i++)
            {
                Student a = new Student("Arman", "12345", y);
                Student b = new Student("Dauren", "12345", y); //call class STOODENTY and giving parameters for it
                a.Print();
                b.Print();
                ++y;//increasing year
            }


        }
    }
}
