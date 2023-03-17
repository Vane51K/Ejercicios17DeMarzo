﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios17DeMarzo
{
    class Program
    {
        static void Main(string[] args)
        {
            ///Ejercicio no.1 

            decimal pi = 3.1416m;

            Console.WriteLine("-----------CIRCULO-----------");
            Console.WriteLine("Ingrese el Radio del Circulo: ");
            decimal radio = decimal.Parse(Console.ReadLine());

            decimal area = pi * radio * radio;

            Console.WriteLine("El Area del Circulo es: " + area);
            Console.ReadLine();

            ///Ejercicio no.2

            Console.WriteLine("-----------RECTANGULO----------");
            Console.WriteLine("Ingrese la anchura del rectangulo: ");
            decimal ancho = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la altura del rectangulo: ");
            decimal altura = decimal.Parse(Console.ReadLine());

            decimal perimetro = 2 * (ancho + altura);

            Console.WriteLine("El perimetro del Rectangulo es de: " + perimetro);
            Console.ReadLine();

            ///Ejercicio no.3

            Console.WriteLine("-------PROMEDIO-------");
            Console.WriteLine("Ingrese su primera nota: ");
            int nota1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese su segunda nota: ");
            int nota2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese su tercera nota: ");
            int nota3 = int.Parse(Console.ReadLine());

            int promedio = (nota1 + nota2 + nota3) / 3;

            Console.WriteLine("Su promedio es de: " + promedio);
            Console.ReadLine();

            ///Ejercicio no.4

            Console.WriteLine("----PAR O IMPAR----");
            Console.WriteLine("Ingrese un numero:");
            int numero = int.Parse(Console.ReadLine());

            if (numero % 2 == 0)
            {
                Console.WriteLine(numero + " es par");
            }
            else
            {
                Console.WriteLine(numero + " es impar");
            }
            Console.ReadLine();

            ///Ejercicio no.5

            Console.WriteLine("Por favor ingrese una palabra:");
            string palabra = Console.ReadLine();

            string palabraEnM = palabra.ToUpper();

            Console.WriteLine("BOOM tu palabra pero en mayusculas BD: " + palabraEnM);
            Console.ReadLine();

            ///Ejercicio no.6

            Console.WriteLine("-------------------COORD-------------------");
            Console.WriteLine("Ingrese las coordenadas del primer punto:");
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese las coordenadas del segundo punto:");
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());

            double distancia = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));

            Console.WriteLine("La distancia entre los dos puntos es: " + distancia);
            Console.ReadLine();

            ///Ejercicio no.7

            Console.Write("Ingrese el número n: ");
            int n = int.Parse(Console.ReadLine());

            int suma = (n * (n + 1)) / 2;

            Console.WriteLine("La suma de los primeros " + n + " números naturales es: " + suma);
            Console.ReadLine();

            ///Ejercicio no.8

            Console.WriteLine("-----------FACTORIAL-----------");
            Console.WriteLine("Ingrese el numero que desea calcular su factorial: ");
            int num = int.Parse(Console.ReadLine());

            int factorial = 1;
            for (int i = 2; i <= num; i++)
            {
                factorial *= i;
            }

            Console.WriteLine($"El factorial de: {num} es: {factorial}");
            Console.ReadLine();
        }
    }
}