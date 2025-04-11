using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] stock = { 10, 10, 10 };
            int[] sales = {0, 0, 0 };
            int[] price = { 100, 150, 200 };
            int count = 0;
            int count2 = 0;

            while (true)
            {
                Console.WriteLine("Добро пожаловать в кофейню мечты!\r\n Выберите действие:\r\n1. Обработать заказ\r\n2. Просмотреть статисику продаж\r\n3. Проверить запасы на складе\r\n4. Заверишть работу ");
                Console.WriteLine();
                string operation = Console.ReadLine();
                switch (operation)
                    {
                    case "1":
                        {
                            Console.WriteLine("Меню напитков:\r\n1. Эспрессо - 100 руб.\r\n2. Капучино - 150 руб.\r\n3. Латте - 200 руб.");
                            string[] menu = {"Эспрессо", "Капучино", "Латте" };
                            int drink = int.Parse(Console.ReadLine());
                            Console.WriteLine("Введите номер напитка: " + drink);
                            if (stock[drink-1] > 0)
                            {
                                Console.WriteLine($"Вы заказали: {menu[drink-1]}. Приятного аппетита");
                                stock[drink-1]--;
                                sales[drink-1]++;
                            }
                            else
                            {
                                Console.WriteLine($"Извините, но {menu[drink-1]} закончился");
                            }
                            break;
                        }
                    case "2":
                        {
                            count = (price[0]*sales[0]) + (price[1] * sales[1]) + (price[2] * sales[2]);
                            Console.WriteLine($"Продано напитков в общем: {count}\r\n Эспрессо - {sales[0] * price[0]}\r\n Капучино - {sales[1] * price[1]}\r\n Латте - {sales[2] * price[2]}");
                            break;
                        }
                    case "3":
                        {
                            Console.WriteLine($"Запасы на складе: \r\n Эспрессо: {stock[0]} в наличии \r\n Капучино: {stock[1]}в наличии \r\n Латте: {stock[2]} в наличии");
                            Console.WriteLine();
                            break;
                        }
                    case "4":
                        {
                            return;
                        }
                    default:
                        {
                            Console.WriteLine("Неправильный ввод");
                            break;
                        }
                    }
            }

        }

    }
}
