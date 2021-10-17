using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Burbuja
{
    class Burbuja
    {
        int[] vector = {10,20,15,78,28};

        public void MetodoBurbuja()
        {
            int t;
            for (int a = 1; a < vector.Length; a++)
                for (int b = vector.Length - 1; b >= a; b--)
                {
                    if (vector[b - 1] > vector[b])
                    {
                        t = vector[b - 1];
                        vector[b - 1] = vector[b];
                        vector[b] = t;
                    }
                }
        }

        public void Imprimir()
        {
            Console.WriteLine("Vector ordenado en forma ascendente");
            for (int f = 0; f < vector.Length; f++)
            {
                Console.Write(vector[f]+"  ");
            }
            Console.ReadKey();
        }

        static void Main(string[] args)
        {
            Burbuja ob = new Burbuja();
            ob.MetodoBurbuja();
            ob.Imprimir();
        }
    }
}