using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int[] randtemparray = new int[7];
            for (int i = 0; i < randtemparray.Length; i++)
            {
                randtemparray[i] = random.Next(-100, 100);
            }
            

            int[,] HighMap = new int[5, 5];
            for (int i = 0; i < HighMap.GetLength(0); i++)
            {
                for (int j = 0; j < HighMap.GetLength(1); j++)
                {
                    HighMap[i, j] = random.Next(0, 1000);
                }
            }
            int num = 0;
            int column = 0;
            int row = 0;

            int number = 0;
            
            while (true)
            {
                Console.WriteLine("Добро пожаловать в симулятор исследовательской миссии на планету!\r\n Выберите действие:\r\n1. Показать температуру за последние 7 дней\r\n2. Найти среднюю температуру за неделю\r\n3. Анализировать карту рельефа планеты\r\n4. Заверишть работу ");
                Console.WriteLine();
                string operation = Console.ReadLine();
                Console.WriteLine("Ваш выбор: " + operation);
                switch (operation)
                {
                    case "1":
                        Console.WriteLine("Температура за последние 7 дней: ");
                        for (int i = 0; i < randtemparray.Length; i++)
                        {
                            Console.Write(randtemparray[i] + " ");
                        }
                        Console.WriteLine();
                        break;
                    case "2":
                        int Average = (randtemparray.Sum() / (randtemparray.Length));
                        Console.WriteLine("Средняя температура за неделю:" + Average);
                        Console.WriteLine(Average);
                        Console.WriteLine();
                        break;
                    case "3":
                        Console.WriteLine("Карта высот (в метрах)");
                        for (int i = 0; i < HighMap.GetLength(0); i++)
                        {
                            for (int j = 0; j < HighMap.GetLength(1); j++)
                            {
                                Console.Write(HighMap[i, j] + " ");
                            }
                            Console.WriteLine();
                        }
                        Console.WriteLine();
                        for (int i = 0; i < HighMap.GetLength(0); i++)
                        {
                            for (int j = 0; j < HighMap.GetLength(1); j++)
                            {
                                if (HighMap[i, j] > number)
                                {
                                    number = HighMap[i, j];
                                    row = i;
                                    column = j;
                                }
                            }

                        }
                        Console.WriteLine($"максимальная точка {number} в точке [{row},{column}] ");
                        for (int i = 0; i < HighMap.GetLength(0); i++)
                        {
                            for (int j = 0; j < HighMap.GetLength(1); j++)
                            {
                                if (HighMap[i, j] < number)
                                {
                                    number = HighMap[i, j];
                                    row = i;
                                    column = j;
                                }
                            }

                        }
                        Console.WriteLine($"минимальная точка {number} в точке [{row},{column}] ");
                        Console.WriteLine();
                        break;
                    case "4":
                        return;
                    default:
                        Console.WriteLine("ненене");
                        break;
                }
            } 
        
        }
    }
}
