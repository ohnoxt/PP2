using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace task4{
    class Program{
        static void Main(string[] args){
            string filename = System.IO.Path.GetRandomFileName();//gives random name for file
            string path = System.IO.Path.Combine(@"..\..", filename);//path for file
            string pathy = @"C:\git\PP2\w2\task4\backupfiles\";//folder which is new location for file
            FileStream file = System.IO.File.Create(path);// creates a file
            file.Close();//closes and saves the file
            System.IO.File.Copy(path, pathy + filename);//copies file to pathy
            System.IO.File.Delete(path);//deletes old file
            Console.ReadKey();
        }
    }
}