using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CoderByte.Algorithms
{
    public class FindIntersection
    {
        public static string Run(string[] strArr)
        {
            var arr1 = strArr[0].Split(",");
            var arr2 = strArr[1].Split(",");
            var lista = new List<string>();

            for (int i = 0; i < arr1.Length; i++)
            {
                int numero = int.Parse(arr1[i]);
                for (int j = 0; j < arr2.Length; j++)
                {
                    int subnumero = int.Parse(arr2[j]);

                    if (numero == subnumero)                    
                        lista.Add(numero.ToString());                    
                }
            }

            if (lista.Count == 0)
                return "false";

            return string.Join(",", lista);
        }

        public static string Run2(string[] strArr)
        {
            var arreglo1 = strArr[0].Split(",").ToList();
            var arreglo2 = strArr[1].Split(",").ToList();

            string cadena = "1,2,3,4,5";
            var array = cadena.Split(",");

            return arreglo1.Intersect(arreglo2).Count() > 0 ? string.Join(",", arreglo1.Intersect(arreglo2)) : "false";

        }
    }
}
