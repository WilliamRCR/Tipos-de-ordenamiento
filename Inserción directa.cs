using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OrdenamientoInsercionDirecta
{
    class OrdenamientoInsercionDirecta
    {
        public int[] vector = {10,20,15,78,28};

        public void InsercionDirecta()
        {
            int cantidad;
            int j;
            for (int i = 0; i < vector.Length; i++)
            {
                cantidad = vector[i];
                j = i - 1;
                while (j >= 0 && vector[j] > cantidad)
                {
                    vector[j + 1] = vector[j];
                    j--;
                }
                vector[j + 1] = cantidad;
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
            OrdenamientoInsercionDirecta oid = new OrdenamientoInsercionDirecta();
            oid.InsercionDirecta();
            oid.Imprimir();
        }
    }
}