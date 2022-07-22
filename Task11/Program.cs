using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Line;

namespace Task11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Дано линейное уравнение kx+b=0");
            Console.WriteLine("Найти x по известным b и k");
            Console.WriteLine("Введите b");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите k");
            double k = Convert.ToDouble(Console.ReadLine());

            Line line = new Line(b, k);
            Console.WriteLine(line.Root());
            Console.ReadKey();
        }
    }
}
