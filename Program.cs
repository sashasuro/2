using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //задача 1
            Console.WriteLine("\tВыскосотный ли сейчас год?\nВведите год в котором вы находитесь:");
            double y = double.Parse(Console.ReadLine());
            if (y % 4 == 0)
                Console.WriteLine($"{y}год - высокостный!");
            else
                Console.WriteLine($"{y}год - не высокостный!");

            //задача 2
            Console.WriteLine("\tЭкономнатор!\nВведите сумму:");
            int pk = int.Parse(Console.ReadLine());
            if (pk >= 20000 && pk <= 30000)
                Console.WriteLine($"{pk}то что надо!");
            else
                Console.WriteLine($"{pk}то что НЕ надо!");

            //задача 3
            Console.WriteLine("\tОценканатор!\nВведите свой балл:");
            int x = int.Parse(Console.ReadLine());
            if (x >= 0 && x <= 59)
            {
                Console.WriteLine($"{x}Неудовлетворительно!");
            }
            else if (x >= 60 && x <= 74)
            {
                Console.WriteLine($"{x}Yдовлетворительно!");
            }
            else if (x >= 75 && x <= 89)
            {
                Console.WriteLine($"{x}Хорошо!");
            }
            else if (x >= 90 && x <= 100)
            {
                Console.WriteLine($"{x}Отлично!");
            }

            //задача 4
            Console.WriteLine("\tСветофор");
            Random rnd = new Random();
            int s = rnd.Next(1, 3);
            switch (s)
            {
                case 1:
                    Console.WriteLine("Красный");
                    break;
                case 2:
                    Console.WriteLine("Жёлтый");
                    break;
                case 3:
                    Console.WriteLine("Зелёный");
                    break;
            }

            //задача 5
            Random rnd = new Random();
            int s = rnd.Next(0, 10);
            Console.WriteLine(s);
            if ((s % 2) == 0)
            {
                Console.WriteLine("Чётное");
            }
            else
            {
                Console.WriteLine("Нечётное");
            }
            Console.ReadKey();
        }
    }
}
