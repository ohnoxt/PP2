using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace task3{
    class Program{
           static void Space_created(int a){
                for(int i=0; i<a; i++){
                    Console.Write("   ");
                }
        }//to recognize level we need to create needed amount of space for it

        static void PrintDirectories(DirectoryInfo path, int cnt = 0){
            DirectoryInfo[] Dirs = path.GetDirectories();//list of directories in current directory
            FileInfo[] Files = path.GetFiles();//list of files in that directory
                for (int i=0; i<Dirs.Length; i++){
                    Space_created(cnt);
                    Console.WriteLine(Dirs[i].Name);
                    PrintDirectories(Dirs[i], cnt+1);//needed to print directory and what located inside of this directory
            }
                for(int i=0; i<Files.Length; i++){
                    Space_created(cnt);
                    Console.WriteLine(Files[i].Name);//after that it prints all file names
                }
            if (Dirs.Length != 0 && Files.Length != 0){
                return;
            }
        }
        static void Main(string[] args){
            DirectoryInfo path = new DirectoryInfo(@"C:\Users\Noxt\Pictures");//path to folder
            PrintDirectories(path);
            Console.ReadKey();
        }
    }
}