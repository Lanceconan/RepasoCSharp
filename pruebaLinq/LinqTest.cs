using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pruebaLinq
{
    class LinqTest
    {
        public void InformacionResultados(Object inputObjetc)
        {
            Console.WriteLine("Tipo {0}", inputObjetc.GetType().Name);
            Console.WriteLine("Locación {0}", inputObjetc.GetType().Assembly.GetName().Name);

        }

        public IEnumerable<int> GetNumbersByFilter(int[] arrayNumeros, int superior, int inferior)
        {
            IEnumerable<int> valores = from n in arrayNumeros
                                       where n > superior && n < inferior
                                       select n;
            return valores;
        }

        public int[] GetNumerosParesArray(int[] inputData)
        {
            int[] valores = (from par in inputData
                             where par % 2 == 0
                             select par).ToArray<int>();
            return valores;
        }

        public List<int> GetNumerosParesList(int[] inputData)
        {
            List<int> valores = (from par in inputData
                             where par % 2 == 0
                             select par).ToList<int>();
            return valores;
        }

        public IEnumerable<int> GetNumerosPares(int[] inputData)
        {
            IEnumerable<int> valores = from par in inputData
                                       where par % 2 == 0
                                       select par;

            return valores;
        }

        public IEnumerable<int> GetNumerosImpares(int[] inputData)
        {
            IEnumerable<int> valores = from par in inputData
                                       where par % 2 != 0
                                       select par;

            return valores;
        }

        public IEnumerable<string> GetStringsByFilter(string[] inputData, string filter)
        {
            IEnumerable<string> filteredString = from filterString in inputData
                                                 where filterString.Contains(filter)
                                                 orderby filterString
                                                 select filterString;
            return filteredString;
        }

        






    }
}
