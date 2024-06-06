/******************************************************************************

Autor: Andres Hernandez
Fecha: 06/06/2024
Descripcion:    Toy Story
     Los juguetes de Andy están 
     jugando a las escondidas. Pide al 
     usuario las ubicaciones donde buscar 
     y usa estructuras "si" para determinar 
     si los juguetes están en la ubicación 
     correcta o no. Reportar la cantidad 
     total de juguetes que fueron encontrados 
     al finalizar 4 rondas.

*******************************************************************************/
using System;

class Program
{
    static void Main(string[] args)
    {
        int juguestesEncontrados = 0;
        string[] ubicacionesCorrectas = { "caja", "armario", "debajo de la cama", "dentro del closet" };

        Console.WriteLine("¡Bienvenido al juego de las escondidas de los juguetes de Andy!");
        Console.WriteLine("Los lugares en los que puedes buscar son:");
        Console.WriteLine("*Cama");
        Console.WriteLine("*armario");
        Console.WriteLine("*debajo de la cama");
        Console.WriteLine("*dentro del closet");
        Console.WriteLine("*cocina");
        Console.WriteLine("*baño");
        Console.WriteLine("*habitacion de los padres");

        int ronda = 1;
        while (ronda <= 4)
        {
            Console.WriteLine("\nRonda " +ronda+":");
            Console.Write("Ingresa la ubicación donde buscarás: ");
            string ubicacionIngresada = Console.ReadLine().ToLower();

            bool encontrado = false;
            int i = 0;
            while (i < ubicacionesCorrectas.Length)
            {
                if (ubicacionIngresada == ubicacionesCorrectas[i])
                {
                    Console.WriteLine("¡Encontraste un juguete!");
                    juguestesEncontrados++;
                    encontrado = true;
                    break;
                }
                i++;
            }

            if (!encontrado)
            {
                Console.WriteLine("No hay juguetes en esa ubicación.");
            }

            ronda++;
        }

        Console.WriteLine("\nEncontraste un total de " + juguestesEncontrados + "juguetes en las 4 rondas.");
        Console.ReadLine();
    }
}