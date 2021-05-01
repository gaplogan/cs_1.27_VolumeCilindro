using System;

namespace cs_1._27_VolumeCilindro
{
    class Program
    {
        static void Main(string[] args)
        {
            double r, a, h, v;

            r = 0;
            while (r <= 0)
            {
                Console.Write("Digite o valor do raio da base do cilindro: ");
                r = double.Parse(Console.ReadLine());
            }

            h = 0;
            while (h <= 0)
            {
                Console.Write("Digite o valor da altura do cilindro: ");
                h = double.Parse(Console.ReadLine());
            }

            a = Math.PI * Math.Sqrt(r); // Área da base.
            v = a * h; // Volume do cilindro.

            Console.WriteLine($"Volume do cilindro {v}");
        }
    }
}
