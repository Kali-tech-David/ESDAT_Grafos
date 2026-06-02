using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grafos
{
    internal class GrafoNPND
    {
        int[,] data;

        public GrafoNPND(int vertices)
        {
            data = new int[vertices, vertices];
        }

        public void Agregar(int origen, int destino)
        {
            data[origen - 1, destino - 1] = 1;
            data[destino - 1, origen - 1] = 1;
        }

        public  void Mostrar()
        {
            Console.WriteLine("   |1|2|3|4|");
            for (int i = 0; i < data.GetLength(0); i++)
            {
                Console.Write($"|{i + 1}| ");
                for (int j = 0; j < data.GetLength(1); j++)
                {
                    Console.Write(data[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
        public bool ValidarNPND(int origen, int destino)
        {
            if (origen == destino) return false;
            else return true;
        }
    }

}
