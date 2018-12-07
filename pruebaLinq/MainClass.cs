using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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
            ConexionBD conexion = new ConexionBD();

            int opcion;

            do
            {
                System.Console.Clear();
                Console.WriteLine("Menú de Básicas Utilidades");
                Console.WriteLine("======================");
                Console.WriteLine("");
                Console.WriteLine("1. Usos de Linq");
                Console.WriteLine("2. Estructuras básicas de control");
                Console.WriteLine("3. Conexión a la base de Datos");
                Console.WriteLine("4. Consulta a la base de Datos");
                Console.WriteLine("5. Consulta a la base de Datos con Linq");
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
                        Console.WriteLine("Ejecución diferida");
                        Console.WriteLine("===================");
                        Console.WriteLine("");


                        int[] numeros = { 2, 3, 15, 6, 1, 2, 212, 34, 4, 21 };

                        IEnumerable<int> valores = linqFunctions.GetNumbersByFilter(numeros, 2, 3000);
                        numeros[6] = 500;
                        basicFunction.PrintFormatedInt(valores);

                        int[] numerosRandom = { 2, 3, 4, 5, 6, 7, 8, 9, 0 };

                        var numerosPares = linqFunctions.GetNumerosPares(numerosRandom);
                        numerosRandom[1] = 10;
                        basicFunction.PrintFormatedInt(numerosPares);

                        Console.WriteLine("Ejecución Inmediata");
                        Console.WriteLine("===================");
                        Console.WriteLine("");

                        int[] numeroInmediatoArray = linqFunctions.GetNumerosParesArray(numerosRandom);
                        numerosRandom[1] = 1;
                        basicFunction.PrintFormatedIntArray(numeroInmediatoArray);

                        List<int> numeroInmediatoList = linqFunctions.GetNumerosParesList(numerosRandom);
                        numerosRandom[1] = 2;
                        basicFunction.PrintFormatedIntList(numeroInmediatoList);

                        string[] postresInput = { "pie de manzana", "kuchen de manzana", "pie limón ", "torta de crema", "manzana confitada" };

                        IEnumerable<string> postresManzana = linqFunctions.GetStringsByFilter(postresInput, "manzana");
                        basicFunction.PrintFormatedString(postresManzana);

                        linqFunctions.InformacionResultados(valores);
                        Console.WriteLine(" ---- -");
                        linqFunctions.InformacionResultados(postresManzana);
                        Console.WriteLine(" ---- -");

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

                        basicFunction.ImprimirMensaje("Uso de For para multiplicar los 25 primeros números");
                        basicFunction.ImprimirMensaje("la Multiplicación es: " + basicFunction.Multiplicar(25));
                        basicFunction.ImprimirMensaje("=====================================================");

                        basicFunction.Pause();
                        break;

                    case 3:
                        System.Console.Clear();
                        conexion.GetConexionBD().Open();
                        Console.WriteLine("SE ABRIÓ LA CONEXIÓN !!!");
                        conexion.GetConexionBD().Close();
                        Console.WriteLine("SE CERRÓ LA CONEXIÓN !!!");
                        basicFunction.Pause();
                        break;
                    case 4:
                        System.Console.Clear();

                        string query = "SELECT * FROM paciente";
                        SqlDataReader registros = conexion.ExecuteQuery(query);

                        while (registros.Read())
                        {
                            Console.Write(registros["id"].ToString());
                            Console.Write(" - ");
                            Console.Write(registros["nombre"].ToString());
                            Console.Write(" - ");
                            Console.Write(registros["apellido"].ToString());
                            Console.WriteLine("");
                        }

                        conexion.CerrarConexion();
                        basicFunction.Pause();

                        break;

                    case 5:
                        System.Console.Clear();

                        var queryLondonCustomers = from cust in customers
                                                   where cust.City == "London"
                                                   select cust;
                        basicFunction.Pause();

                        break;
                    case 9:
                        System.Console.Clear();
                        basicFunction.ImprimirMensaje("Has salido del programa más básico de C# .... \n\n:( \n\n... Adios !\n\n");
                        basicFunction.Pause();
                        break;



                }
            } while (opcion != 9);
        }
    }
}
