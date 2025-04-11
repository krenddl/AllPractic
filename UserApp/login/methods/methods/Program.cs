using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methods
{
    internal class Program
    {
        static void Hello()
        {
            Console.WriteLine("Hello World!");
        }
        static void PrinHello(string name)
        {
            var text = "Hello" + name + "!";
            Console.WriteLine(text);
        }
        static int Cube(int x)
        {
            return x * x * x;
        }
        static void Main(string[] args)
        {
            Hello();
            PrinHello("Amir");
            var b1 = Cube(2);
            var b2 = Cube(3);
            Console.WriteLine(b1 + b2);
        }
    }
}
