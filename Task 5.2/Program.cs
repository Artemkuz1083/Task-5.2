using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_5._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 5.2");
            Console.Write("Введите число: ");
            string str = Console.ReadLine();
            HomeWork2(str);
        }


        public static void HomeWork2(string str)
        {
            Char[] strNumbers = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
            str.Trim();
            int sum = 0;            
            for (int i = 0; i < str.Length; i++) 
            {
                if (strNumbers.Contains(str[i]))
                {
                    sum += Array.IndexOf(strNumbers,str[i]);
                }
                else if (str[i] == '-' && i == 0)
                {
                    continue;
                }
                else
                {
                    Console.WriteLine("Число введено не корректно");
                    return;
                }
            }
            Console.WriteLine($"Результат: {sum}");
        }
    }
}
