using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace CoderByte.Algorithms
{
    public class LongestWord
    {
        public static string Run(string texto)
        {
            texto = new string((from l in texto where char.IsWhiteSpace(l) || char.IsLetterOrDigit(l) select l).ToArray());

            int maxCount = 0;            
            string maxPalabra = "";
            string[] palabras = texto.Split(" ");

            foreach(var palabra in palabras)
            {
                int contador = 0;

                foreach(char letra in palabra)
                {
                    contador++;
                }

                if(contador > maxCount)
                {
                    maxCount = contador;
                    maxPalabra = palabra;
                }

            }

            return maxPalabra;
        }

        public static string Run2(string texto)
        {
            string[] arregloPalabras = texto.Split(" ");
            int maxCount = 0;
            string maxWord = "";

            foreach(var palabra in arregloPalabras)
            {
                if(palabra.Length > maxCount)
                {
                    maxCount = palabra.Length;
                    maxWord = palabra;
                }
            }
            return maxWord;
        }
    }
}
