﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejercicio9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 09";

            Console.Write("Ingrese el tamaño de la piramide: ");
            int n = int.Parse(Console.ReadLine());

            for (int lactual = 1; lactual <= n; lactual++)
            {
                for (int asterisco = 0; asterisco < (lactual * 2) - 1; asterisco++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
