using System;
using System.Net.WebSockets;

namespace horasExtras
{
    class Program
    {
        static void Main(string[] args)
        {
            double salarioHora = 0.0;
            double horasTrabalhadas = 0.0;
            double horasExtras = 0.0;

            Console.WriteLine("Vamos calcular seu salário com horas extras. Pressione uma tecla para prosseguirmos.");
            Console.ReadKey();

            Console.Write("Digite seu salário por hora:");
            salarioHora = Convert.ToDouble(Console.ReadLine()!);

            Console.Write("Digite o total de horas trabalhadas:");
            horasTrabalhadas = Convert.ToDouble(Console.ReadLine()!);

            Console.Write("Digite o total de horas extras trabalhadas:");
            horasExtras = Convert.ToDouble(Console.ReadLine()!);

            Console.WriteLine($"Seu salario com horas extras: {salariocalculado( salarioHora, horasTrabalhadas, horasExtras):C}");
        }

         static double salariocalculado(double salarioHora, double horasTrabalhadas, double horasExtras)
        {
            double total = 0.0;
            double totalComHoraExtra = 0.0;

            total = salarioHora * horasTrabalhadas;

            totalComHoraExtra = total + (salarioHora * (horasExtras * 0.4));

            return totalComHoraExtra;
        }


    }
}