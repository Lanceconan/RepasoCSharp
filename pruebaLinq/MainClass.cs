using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pruebaLinq
{
    class MainClass
    {
        static void Main(string[] args)
        {
            LinqTest linqFunctions = new LinqTest();
            BasicFunctions basicFunction = new BasicFunctions();
            int opcion;

            do
            {
                System.Console.Clear();
                Console.WriteLine("Menú de Básicas Utilidades");
                Console.WriteLine("======================");
                Console.WriteLine("");
                Console.WriteLine("1. Usos de Linq");
                Console.WriteLine("2. Estructuras básicas de control");
                Console.WriteLine("9. Salir");

                opcion = basicFunction.getInputNumberByKey("Ingresa tu opción: ");

                switch (opcion)
                {
                    case 0:
                    default:
                        System.Console.Clear();
                        Console.WriteLine("Ingreso no válido");
                        break;

                    case 1:
                        System.Console.Clear();

                        int[] numeros = { 2, 3, 12, 6, 1, 2, 212, 34, 4, 21 };

                        IEnumerable<int> valores = linqFunctions.GetNumbersByFilter(numeros, 2, 3000);

                        basicFunction.printFormatedInt(valores);

                        string[] postresInput = { "pie de manzana", "kuchen de manzana", "pie limón ", "torta de crema", "manzana confitada" };

                        IEnumerable<string> postresManzana = linqFunctions.GetStringsByFilter(postresInput, "manzana");

                        basicFunction.printFormatedString(postresManzana);

                        linqFunctions.InformacionResultados(valores);
                        Console.WriteLine(" ---- -");
                        linqFunctions.InformacionResultados(postresManzana);
                        Console.WriteLine(" ---- -");

                        int[] numerosRandom = { 2, 3, 4, 5, 6, 7, 8, 9, 0 };

                        var numerosPares = linqFunctions.GetNumerosPares(numerosRandom);

                        basicFunction.printFormatedInt(numerosPares);

                        basicFunction.Pause();
                        break;

                    case 2:
                        System.Console.Clear();

                        basicFunction.ImprimirMensaje("Uso de if para saber que número es mayor entre 4 y 6");
                        basicFunction.ImprimirMensaje("El mayor es: " + basicFunction.Mayor(4, 6));
                        basicFunction.ImprimirMensaje("=====================================================");

                        basicFunction.ImprimirMensaje("Uso de while para sumar los 500 primeros números");
                        basicFunction.ImprimirMensaje("La suma es: " + basicFunction.Sumar(500));
                        basicFunction.ImprimirMensaje("=====================================================");

                        basicFunction.ImprimirMensaje("Uso de for para multiplicar los 25 primeros números");
                        basicFunction.ImprimirMensaje("la Multiplicación es: " + basicFunction.Multiplicar(25));
                        basicFunction.ImprimirMensaje("=====================================================");

                        basicFunction.Pause();
                        break;
                    case 9:
                        System.Console.Clear();
                        basicFunction.ImprimirMensaje("Has salido del programa más básico de C# .... :( ... Adios !");
                        break;



                }
            } while (opcion != 9);


            

        }
    }
}
