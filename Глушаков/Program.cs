using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Глушаков
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int b;
            Console.WriteLine("Выбранно рандомное число : ...");
            Random a = new Random();
            int value = a.Next(0, 10);
            Console.WriteLine("Предположите число :");
            b = int.Parse(Console.ReadLine());
            string[] words = new string[3] { " Мимо", " Рекошет", " Не пробил" };
            Random c = new Random();
            for (int i = 0; i < 5; i++)
            {

                if
                (b == value)
                {
                    Console.WriteLine(" Пробил");
                    break;
                }

                else
                {
                    if (b < value)
                    {
                        Console.WriteLine(" Число больше ");
                        Console.WriteLine();

                    }
                    else
                    {
                        Console.WriteLine(" Число меньше ");
                        Console.WriteLine();
                    }
                    int vvalue = c.Next(0, 3);
                    Console.WriteLine(words[vvalue]);
                    Console.WriteLine();
                    b = int.Parse(Console.ReadLine());

                }



            }

            Console.ReadKey();
        }
    }
}
