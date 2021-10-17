using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Quicksort
{
    class Class
    {
        static void Main()
        {
            int n;
            Console.WriteLine("Metodo de Quick Sort");
            Console.Write("Longitud del vector: ");
            n = Int32.Parse(Console.ReadLine());
            llenar b = new llenar(n);
        }
    }

    class llenar
    {
        int h;
        int[] vector;
        public llenar(int n)
        {
            h = n;
            vector = new int[h];
            for (int i = 0; i < h; i++)
            {
                Console.Write("ingrese valor {0}: ", i + 1);
                vector[i] = Int32.Parse(Console.ReadLine());
            }
            Quicksort(vector, 0, h - 1);
            Imprimir();
        }

        public void Quicksort(int[] vector, int primero, int ultimo)
        {
            int i, j, central;
            double pivote;
            central = (primero + ultimo) / 2;
            pivote = vector[central];
            i = primero;
            j = ultimo;
            do
            {
                while (vector[i] < pivote) i++;
                while (vector[j] > pivote) j--;
                if (i <= j)
                {
                    int temp;
                    temp = vector[i];
                    vector[i] = vector[j];
                    vector[j] = temp;
                    i++;
                    j--;
                }
            } while (i <= j);

            if (primero < j)
            {
                quicksort(vector, primero, j);
            }
            if (i < ultimo)
            {
                quicksort(vector, i, ultimo);
            }
        }

        private void Imprimir()
        {
            Console.WriteLine("Vector ordenado en forma ascendente");
            for (int i = 0; i < h; i++)
            {
                Console.Write("{0} ", vector[i]);
            }
            Console.ReadLine();
        }
    }
}
