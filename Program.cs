using System;

namespace Medidas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite a medida em metros que deseja: ");
            string valordaMedida = Console.ReadLine();
            double numerodaMedida = Double.Parse(valordaMedida);

            Console.WriteLine();

            Console.WriteLine("Medidas em cm: " + numerodaMedida*100);
            Console.WriteLine("Medidas em m: " + numerodaMedida);
            Console.WriteLine("Medidas em km: " + numerodaMedida*0.001);
        }
    }
}
