using System;

namespace CalculoBhaskara
{
    class Program
    {
        static void Main(string[] args)
        {
            double A, B, C;
            double X1, X2;

            Console.WriteLine("Insira o valor de A: ");
            A = double.Parse(Console.ReadLine());

            Console.WriteLine("Insira o valor de B: ");
            B = double.Parse(Console.ReadLine());

            Console.WriteLine("Insira o valor de C: ");
            C = double.Parse(Console.ReadLine());

            if((A==0)|(Math.Pow(B,2) -4*A*C < 0))
            {
                Console.WriteLine("Impossível calcular");
            }
            else 
            {
                X1 = (-B + Math.Sqrt(Math.Pow(B,2) - 4*A*C))/(2*A);
                X2 = (-B - Math.Sqrt(Math.Pow(B,2) - 4*A*C))/(2*A);

                Console.WriteLine("O valor de X1 e X2 são:");
                Console.WriteLine("X1 = {0}", Math.Round(X1,5));
                Console.WriteLine("X2 = {0}",Math.Round(X2,5));
            }
        }
    }
}
