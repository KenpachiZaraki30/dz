using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _123321
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //int a, b;
            //Console.WriteLine("Enter first number");
            //a = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter second number");
            //b = int.Parse(Console.ReadLine());
            //if (a > b) Console.WriteLine($"{b} {a}");
            //else Console.WriteLine(a+" "+b);
            //int a;
            //Console.WriteLine("Enter number");
            //a = int.Parse(Console.ReadLine());
            //if (a%2 == 0) Console.WriteLine(a*3);
            //else Console.WriteLine((double)a/2);
            double sales1, sales2, sales3, wage1, wage2, wage3;
            double rate1, rate2, rate3;
            const int salary = 200;
            const int bonus = 200;
            Console.WriteLine("Enter sales of the first manager");
            sales1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter sales of the second manager");
            sales2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter sales of the third manager");
            sales3 = double.Parse(Console.ReadLine());
            if (sales1 < 500) rate1 = 0.03;
            else if (sales1 >= 500 && sales1 <= 1000) rate1 = 0.05;
            else rate1 = 0.08;
            if (sales2 < 500) rate2 = 0.03;
            else if (sales2 >= 500 && sales2 <= 1000) rate2 = 0.05;
            else rate2 = 0.08;
            if (sales3 < 500) rate3 = 0.03;
            else if (sales3 >= 500 && sales3 <= 1000) rate3 = 0.05;
            else rate3 = 0.08;
            wage1 = salary + sales1 * rate1;
            wage2 = salary + sales2 * rate2;
            wage3 = salary + sales3 * rate3;
            if (wage1 > wage2 && wage1 > wage3) wage1 += bonus;
            else if (wage2 > wage1 && wage2 > wage3) wage2 += bonus;
            else wage3 += bonus;
            Console.WriteLine($"wage of the first manager is {wage1}$");
            Console.WriteLine($"wage of the second manager is {wage2}$");
            Console.WriteLine($"wage of the third manager is {wage3}$");





















        }
    }
}
