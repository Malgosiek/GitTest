using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitTest
{
    class Program
    {
        static void Main(string[] args)
        {
            AnotherClass anotherClass = new AnotherClass("John", 23);
            Console.WriteLine("Hello " + anotherClass.Name +"!");

            Console.ReadKey();
        }
    }
}
