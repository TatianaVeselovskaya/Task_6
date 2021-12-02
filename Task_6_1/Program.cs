using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_6_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string words, result;
            Console.WriteLine("Введите предложение");
            words = Console.ReadLine();
            string[] split = words.Split(' ');
            result = split[0];

            foreach (string s in split)
            {
                if (s.Trim() != "")
                {
                    if (result.Length < s.Length) result = s;
                }
            }
            Console.WriteLine("Самое длинное слово - " + result);
            Console.ReadKey();
        }
    }
}
