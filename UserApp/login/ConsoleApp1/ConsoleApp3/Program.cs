using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {

      
        static void Main(string[] args)
        {
            

            try
            {
                int number = int.Parse(Console.ReadLine());
                if (number < 0)
                {
                    throw new Exception("Ввод отрицательного числа");
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
