using pilasEstaticasC_;

Pila miPila = new Pila();

while (true)
{
    Console.WriteLine("Seleccione una operación:");
    Console.WriteLine("1. Push");
    Console.WriteLine("2. Pop");
    Console.WriteLine("3. Elemento Superior");
    Console.WriteLine("4. Salir");

    if (int.TryParse(Console.ReadLine(), out int opcion))
    {
        switch (opcion)
        {
            case 1:
                Console.WriteLine("Ingrese el elemento a insertar:");
                if (int.TryParse(Console.ReadLine(), out int elementoPush))
                {
                    miPila.Push(elementoPush);
                }
                else
                {
                    Console.WriteLine("Entrada no válida. Ingrese un número entero.");
                }
                break;

            case 2:
                miPila.Pop();
                break;

            case 3:
                int elementoSuperior = miPila.Top();
                if (elementoSuperior != -1)
                {
                    Console.WriteLine($"Elemento superior de la pila: {elementoSuperior}");
                }
                break;

            case 4:
                Environment.Exit(0);
                break;

            default:
                Console.WriteLine("Opción no válida. Intente de nuevo.");
                break;
        }
    }
    else
    {
        Console.WriteLine("Entrada no válida. Ingrese un número entero.");
    }

    Console.WriteLine();
}