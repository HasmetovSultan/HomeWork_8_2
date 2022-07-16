using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_8_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<int> hash = new HashSet<int>();
            Console.WriteLine($"ВЫХОД - X \nВЫВОД НА КОНСОЛЬ - P\n");

            for (int i = 0; ;)
            {
                Console.WriteLine("Введите число");
                string str = Console.ReadLine();

                switch (str.ToUpper())
                {
                    case "X":
                        Environment.Exit(0); break;
                    case "P":
                        foreach (var item in hash)
                            Console.Write($"[{item}]");
                        Console.WriteLine("\n");
                        break;
                    default:
                        if (Int32.TryParse(str, out int res))
                        {
                            if (hash.Add(res))
                                Console.WriteLine($"Успешно!");
                            else
                                Console.WriteLine($"Это уже было\nПопробуй снова");
                        }
                        break;
                }
            }
        }
    }
}
