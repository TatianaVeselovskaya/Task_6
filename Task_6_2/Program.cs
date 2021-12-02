using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_6_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string words, result, result_back;

            Console.WriteLine("Введите предложение");
            words = Console.ReadLine();

            string[] split = words.Split(' ');

            result = "";
            foreach (string s in split)
            {
                if (s.Trim() != "")
                {
                    result = result + s;
                }
            }
            char[] reverse = result.Reverse().ToArray();

            result_back = "";
            foreach (Char ch in reverse)
            {
                result_back = result_back + ch;

            }

            if (string.Compare(result, result_back, true) == 0)
                Console.WriteLine("Строка палиндром ");
            else Console.WriteLine("Строка не палиндром ");
            Console.ReadKey();
        }
    }
}
