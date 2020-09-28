using System;

namespace ConsoleApp2
{
    class complex
    {
        double p, fi;
        double a, b;
        public complex(double p, double fi)
        {
            this.p = p;
            this.fi = fi;

            toAlg();
        }

        private void toTrig()
        {

            p = Math.Sqrt(a * a + b * b);
            fi = Math.Acos(a / p);
        }


        private void toAlg()
        {
            a = p * Math.Cos(fi);
            b = p * Math.Sin(fi);

        }

        public static complex pow(complex x, int n)
        {

            double newp = Math.Pow(x.p, n);
            double newfi = n * x.fi;
            complex newc = new complex(newp, newfi);
            newc.toAlg();
            return newc;

        }

        public static complex operator +(complex x, complex y)
        {

            double newa, newb;

            newa = x.a + y.a;
            newb = x.b + y.b;
            complex newc = new complex(0, 0);
            newc.a = newa;
            newc.b = newb;
            newc.toTrig();

            return newc;
        }

        public static complex operator -(complex x, complex y)
        {

            double newa, newb;

            newa = x.a - y.a;
            newb = x.b - y.b;
            complex newc = new complex(0, 0);
            newc.a = newa;
            newc.b = newb;
            newc.toTrig();

            return newc;
        }


        public static complex operator *(complex x, complex y)
        {
            double newp, newfi;
            newp = x.p * y.p;
            newfi = x.fi + y.fi;
            complex newc = new complex(newp, newfi);
            newc.toAlg();
            return newc;

        }
        public static complex operator /(complex x, complex y)
        {
            double newp, newfi;
            newp = x.p / y.p;
            newfi = x.fi - y.fi;
            complex newc = new complex(newp, newfi);
            newc.toAlg();
            return newc;

        }

        public void printTrig()
        {
            Console.Write(p + "+(cos(" + fi + ")+i*sin(" + fi + "))");


        }

        public void printAlg()
        {
            Console.Write(a + "+i" + b);
        }

    }
}