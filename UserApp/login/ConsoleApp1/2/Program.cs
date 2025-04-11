using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    internal class Program
    {
        static void Main(string[] args)
        {


            try
            {
                int[] array = new int[5];
                Random rnd = new Random();
                for (int i = 0; i < array.Length; i++)
                {
                    array[i] = rnd.Next(1, 10);
                    Console.Write(array[i] + " ");
                }
                int number = int.Parse(Console.ReadLine());
                Console.WriteLine(array[number]);
            }

            catch (IndexOutOfRangeException ex) 
            {
                Console.WriteLine(ex.Message);
            }
            
        }
    }
}
