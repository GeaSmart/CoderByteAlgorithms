using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace CoderByte.Algorithms
{
    public class FirstReverse
    {
        public static string Run(string input)
        {
            Stack pila = new Stack();
            string response= "";

            var arreglo = input.ToCharArray();

            foreach(var item in arreglo)
            {
                pila.Push(item);
            }

            while(pila.Count > 0)
            {
                response += pila.Pop().ToString();
            }
            return response;
        }
    }
}
