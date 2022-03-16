using System;
using System.Collections.Generic;
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
    }
}
