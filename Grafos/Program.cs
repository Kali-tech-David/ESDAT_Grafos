using System;
using Grafos;

namespace Grafo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Ingrese la cantidad de vértices que desea utilizar:");
            Console.Write("-> ");
            int v = int.Parse(Console.ReadLine()!);
            GrafoNPND grafoNpNd = new GrafoNPND(v);




            Console.WriteLine("Ingrese la cantidad de aristas que desea utilizar: ");
            Console.Write("-> ");

            int a = int.Parse(Console.ReadLine()!);
            for(int i = 0; i < a; i++)
            {
                Console.Write("Vertice de Origen: ");
                int val1 = int.Parse(Console.ReadLine()!);
                Console.Write("Vertice de Destino: ");
                int val2 = int.Parse(Console.ReadLine()!);

                int verticeO = Validar(val1, v) ? val1 : 0;
                int verticeD = Validar(val2, v) ? val2 : 0;

                if(verticeO != 0 && verticeD != 0)
                {
                    if (grafoNpNd.ValidarNPND(verticeO, verticeD))
                        grafoNpNd.Agregar(verticeO, verticeD);
                    else
                    { 
                        Console.WriteLine("Ingrese valores diferentes para los vértices.");
                        i--;
                    }
                }
                else
                {
                    Console.WriteLine("Ingrese un vértice permitido.");
                    i--;
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            grafoNpNd.Mostrar();
        }

        public static bool Validar(int num, int max)
        {
            if (num <= max && num > 0)
                return true;
            else return false;
        }
    }
}