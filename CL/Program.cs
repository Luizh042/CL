using System;
namespace CL
{
    public class Program // e uma classe 
    {
        public static void Main(string[] args)
        {
        Calculadora calculadora = new Calculadora();
        int resultado = calculadora.Soma(2,6);
        Console.WriteLine("O resultado da soma é: " + resultado);

        }
    }
}