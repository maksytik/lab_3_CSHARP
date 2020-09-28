using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {

            complex a, b, c, d;

            double p, fi;

            Console.WriteLine("Введите p числа а:");
            p = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите fi числа а:");
            fi = Convert.ToDouble(Console.ReadLine());
            a = new complex(p, fi);

            Console.WriteLine("Введите p числа b:");
            p = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите fi числа b:");
            fi = Convert.ToDouble(Console.ReadLine());
            b = new complex(p, fi);

            Console.WriteLine("Введите p числа c:");
            p = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите fi числа c:");
            fi = Convert.ToDouble(Console.ReadLine());
            c = new complex(p, fi);

            Console.WriteLine("Введите p числа d:");
            p = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите fi числа d:");
            fi = Convert.ToDouble(Console.ReadLine());
            d = new complex(p, fi);


            complex result = complex.pow(b, 3) + (a + b) / (c - a) * d;

            Console.WriteLine("Ответ в тригонометрической форме:");
            result.printTrig();
            Console.WriteLine();
            Console.WriteLine("Ответ в алгебраической форме:");
            result.printAlg();
            Console.WriteLine();

            Console.WriteLine("end");
            Console.ReadKey();

        }
    }
}