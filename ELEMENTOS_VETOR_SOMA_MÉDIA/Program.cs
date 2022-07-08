using System;
using System.Globalization;

namespace ELEMENTOS_VETOR_SOMA_MÉDIA
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            double[] vet;

            Console.Write("Quantos números serão digitados? ");
            n = int.Parse(Console.ReadLine());
            vet = new double[n];


            string[] s = Console.ReadLine().Split(' ');
            double soma = 0.0;

            Console.WriteLine();
            for (int i = 0; i < n; i++)
            {
                vet[i] = double.Parse(s[i]);
                Console.Write(vet[i].ToString("F1", CultureInfo.InvariantCulture) + " ");
                soma += (vet[i]);
            }
            Console.WriteLine();
            Console.WriteLine($"A soma dos números inseridos é {soma.ToString("F2", CultureInfo.InvariantCulture)}.");
            double media = soma / n;
            Console.WriteLine($"A média dos números inseridos é {media.ToString("F2", CultureInfo.InvariantCulture)}.");


        }
    }
}
