using System;
using System.Collections.Generic;
using System.Text;

namespace CoderByte.Algorithms
{
    public class FirstFactorial
    {
        public static int Run(int numero)
        {
            int response = 1;

            for(int i = 1; i <= numero; i++)
            {
                response *= i;
            }

            return response;
        }
    }
}
