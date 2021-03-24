using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversorDeTemperaturas
{
    class Program
    {
        static void Main(string[] args)
        {

            double c, f, k;

            Console.WriteLine("##### CONVERSOR DE TEMPERATURAS #####");
            Console.WriteLine("Insira a temperatura em Celsius: ");
            c = double.Parse(Console.ReadLine());
            Console.WriteLine("--------------------------------------");

            // Calculo para Farenheit (temperatura em celsius * 9 / 5) + 32

            f = (c * 9 / 5) + 32;

            //Calculo para Kelvin (Temperatura em Celsius +273,15)

            k = c + 273.15;

            Console.WriteLine(c + " Graus Celsius  => " + f + " Graus Farenheit");

            Console.WriteLine(c + " Graus Celsius  => " + k + " Graus Kelvin");

            Console.WriteLine("--------------------------------------");


            Console.ReadKey();


        }
    }
}