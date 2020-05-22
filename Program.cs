using System;

namespace Medidas
{
    class Program
    {
        static void Main(string[] args)
        {
           Console.WriteLine("Olá usuário, digite um valor em metros e receba o valor equivalente em quilômetros e centímetros.");

            int metros = Int32.Parse (Console.ReadLine());



            int centimetros = 100; 

            double quilometros = 0.001;



            Console.WriteLine (centimetros * metros +  " cm");

            Console.WriteLine (metros +  " m");

            Console.WriteLine (quilometros * metros +  " km");
        }
    }
}
