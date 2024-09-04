using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringInput
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;

            Console.WriteLine("Введіть рядок англійською мовою:");
            string input = Console.ReadLine().Trim().ToLower();

            Dictionary<char, int> letterCount = new Dictionary<char, int>();

            foreach (char c in input)
            {
                if (char.IsLetter(c))
                {
                    if (letterCount.ContainsKey(c))
                    {
                        letterCount[c]++;
                    }
                    else
                    {
                        letterCount[c] = 1;
                    }
                }
            }

            Console.WriteLine("\nКількість появ кожної літери в рядку:");
            foreach (var item in letterCount)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
        }
    }
}
