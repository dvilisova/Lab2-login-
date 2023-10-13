using System;
using System.Text.RegularExpressions;
using static Lab2_login_.Register;

namespace Lab2_login_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите логин");
            string input = Console.ReadLine();
            Console.WriteLine("Введите пароль");
            string input2 = Console.ReadLine();
            Console.WriteLine("Повторите пароль");
            string input3 = Console.ReadLine();
            (string result, string result1) = new Register().CheckRegister(input, input2, input3);
            Console.WriteLine(result);
            Console.WriteLine(result1);
        }
    }
}
