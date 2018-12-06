using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pruebaLinq
{
    class BasicFunctions
    {
        public void ImprimirMensaje(string mensaje)
        {
            Console.WriteLine(mensaje);
        }

        public void Pause()
        {
            ImprimirMensaje("Presiona una tecla para continuar ... ");
            Console.ReadKey();
        }

        public int getInputNumberByKey(string textoCabecera)
        {
            Console.Write(textoCabecera);

            string inputString = Console.ReadLine();

            try
            {
                return int.Parse(inputString);
            }
            catch (FormatException)
            {
                return 0;
            }
            catch (ArgumentNullException)
            {
                return 0;
            }
            catch (OverflowException)
            {
                return 0;
            }
        }

        public string getInputStringByKey(string textoCabecera)
        {
            Console.Write(textoCabecera);
            string inputString = Console.ReadLine();

            return inputString;

        }

        public void printFormatedString(IEnumerable<string> inputData)
        {
            foreach (string str in inputData)
                Console.WriteLine(str);

            Console.WriteLine(" ---- ");

        }

        public void printFormatedInt(IEnumerable<int> inputData)
        {
            foreach (int num in inputData)
                Console.WriteLine(num);

            Console.WriteLine(" ---- ");
        }

        public int Mayor(int n1, int n2) 
        {
            if (n1 > n2) {
                return n1;
            }
            else if (n1 == n2){
                return 0;
            }
            else
            {
                return n2;
            }
        }

        public long Sumar(int n)
        {
            long sumar = 0;
            while(n >= 0)

            {
                sumar += n;
                n--;
            }
            return sumar;
        }

        public long Multiplicar(int n)
        {
            long multiplicar = 1;
            for(int i=1; i<=n; i++)
            {
                multiplicar *= i;
            }

            return multiplicar;
        }
    }
}
