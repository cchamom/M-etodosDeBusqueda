using System;
using MetodosBusqueda_C_;

public class Program
{
    public static void Main(string[] args)
    {
        int[] A_Secuencial = { 4, 7, 2, 8, 3, 0, 5, 8 }; 
        int[] A_Binaria = { 0, 2, 3, 4, 5, 7, 8, 8 };    
        int dato = 8;

        Console.WriteLine("Seleccione el tipo de búsqueda:");
        Console.WriteLine("1 - Búsqueda Secuencial");
        Console.WriteLine("2 - Búsqueda Binaria");

        string opcion = Console.ReadLine();

        if (opcion == "1")
        {
            // Búsqueda Secuencial
            BusquedaSecuencial busquedaSecuencial = new BusquedaSecuencial();
            int pos = busquedaSecuencial.BuscarElemento(A_Secuencial, dato);

            if (pos != -1)
            {
                Console.WriteLine("Búsqueda Secuencial: El elemento fue encontrado en la posición " + (pos + 1));
            }
            else
            {
                Console.WriteLine("Búsqueda Secuencial: El elemento no fue encontrado");
            }
        }
        else if (opcion == "2")
        {
            //Búsqueda Binaria
            BusquedaBinaria busquedaBinaria = new BusquedaBinaria();
            int pos = busquedaBinaria.BuscarElemento(A_Binaria, dato);

            if (pos != -1)
            {
                Console.WriteLine("Búsqueda Binaria: El elemento fue encontrado en la posición " + (pos + 1));
            }
            else
            {
                Console.WriteLine("Búsqueda Binaria: El elemento no fue encontrado");
            }
        }
        else
        {
            Console.WriteLine("Opción no válida");
        }
    }
}
