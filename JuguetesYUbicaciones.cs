/******************************************************************************

Autor: Andres Hernandez
Fecha: 06-06-2024
Descripcion: Toy Story
             los juguetes de andy estan jugando a las escondidas
             pide al usuario a las escondidas. pide al usuario las
             ubicaciones donde buscar y usa estructuras "si" para determinar
             si los juguetes estan en la ubicacion correcta o no. 
             Reportar la cantidad total de juguetes que fueron encontrados
             al finalizar 4 rondas 
             // variables
             // estructura repititiva o ciclica 
             // preguntar ubicaciones con estructura if
             // acumular juguetes encontrados
             // mostrar juguetes encontrados 

*******************************************************************************/
using System;

class Program
{
    static void Main(string[] args)
    {
        // variables
        int juguestesEncontrados = 0;
        string[] ubicacionesCorrectas = { "caja", "armario", "debajo de la cama", "dentro del closet" };

        Console.WriteLine("¡Bienvenido al juego de las escondidas de los juguetes de Andy!");
        Console.WriteLine("Los lugares en los que puedes buscar son:");
        Console.WriteLine("caja del carro");
        Console.WriteLine("debajo del techo ");
        Console.WriteLine("en el garaje");
        Console.WriteLine("arriba de la alberca");
        Console.WriteLine("sotano");
        Console.WriteLine("habitacion de los niños");
        // estructura repetitiva o ciclicla
        for (int ronda = 1; ronda <= 4; ronda++)
        {
            // preguntar ubicaciones al usuario
            Console.WriteLine("\nRonda" + ronda +":");
            Console.Write("Ingresa la ubicación donde buscarás: ");
            string ubicacionIngresada = Console.ReadLine().ToLower();
            // validar ubicaciones con estructura IF
            bool encontrado = false;
            for (int i = 0; i < ubicacionesCorrectas.Length; i++)
            {
                if (ubicacionIngresada == ubicacionesCorrectas[i])
                {
                    Console.WriteLine("¡Encontraste un juguete!");
                    // acumular juguetes encontrados
                    juguestesEncontrados++;
                    encontrado = true;
                    break;
                }
            }

             if (!encontrado)
            {
                Console.WriteLine("No hay juguetes en esa ubicación.");
            }
        }
        //mostrar juguetes encontrados
        Console.WriteLine("\nEncontraste un total de " + juguestesEncontrados + " juguetes en las 4 rondas.");
        // fin
    }
}