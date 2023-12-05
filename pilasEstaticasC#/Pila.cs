using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pilasEstaticasC_
{
    internal class Pila
    {
        private const int MAX_SIZE = 10;
        private int[] arreglo = new int[MAX_SIZE];
        private int tope = -1;

        public bool EstaVacia()
        {
            return tope == -1;
        }

        public bool EstaLlena()
        {
            return tope == MAX_SIZE - 1;
        }

        public void Push(int elemento)
        {
            if (!EstaLlena())
            {
                arreglo[++tope] = elemento;
                Console.WriteLine($"Se ha insertado {elemento} en la pila.");
            }
            else
            {
                Console.WriteLine("La pila está llena. No se puede insertar.");
            }
        }

        public void Pop()
        {
            if (!EstaVacia())
            {
                Console.WriteLine($"Se ha eliminado {arreglo[tope--]} de la pila.");
            }
            else
            {
                Console.WriteLine("La pila está vacía. No se puede eliminar.");
            }
        }

        public int Top()
        {
            if (!EstaVacia())
            {
                return arreglo[tope];
            }
            else
            {
                Console.WriteLine("La pila está vacía. No hay elemento superior.");
                return -1; // Valor sentinela para indicar que la pila está vacía
            }
        }
    }
}

