using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_rabota
{
    
    class Program
    {
            static void Main(string[] args)
            {
            Console.WriteLine("Введите число x");
            int x = int.Parse(Console.ReadLine());
            double r1 = Math.Pow(x, 3);
            Console.WriteLine("Введите число y");
            int y = int.Parse(Console.ReadLine());
            double r2 = Math.Pow(y, 3);
            Console.WriteLine("Куб большего из чисел");
            double r3 = Math.Max(r1, r2);
            Console.WriteLine(r3);

            Console.ReadKey();
            
        }
    }
}
