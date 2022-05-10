using System;

namespace Solostov18_10
{

    public class UnitTest
    {
        public static double var(string a)
        {
            Console.WriteLine("Введите " + a);
            return Convert.ToDouble(Console.ReadLine());

        }
        public static bool Uslovie1 (double x, double c)
        {
            return x < 5 && c != 0;
        }

        public static bool Uslovie2 (double x, double c)
        {
            return (x > 5 && c == 0);
        }
        public static string Resultat (double a, double x, double b, double c)
        {
           if (Uslovie1(x, b))
                return "F=" + Convert.ToString((-a)*(Math.Pow(x, 2))-b);
           else if (Uslovie2(x, b))
                return "F=" + Convert.ToDouble((x - a)/x); 
           else
                return "F=" + Convert.ToString(-x/c);

        }   
        static void Main (string[] args)
        {
            double a = var("a");
            double b = var("b");
            double c = var("c");
            double x = var("x");
            Resultat(a, b, c, x);
        }
    }
}