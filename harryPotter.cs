/*

Autor: Andres Hernandez
Fecha: 11/07/2024

Descripcion:

Harry Potter necesita un programa 
en C# para listar sus hechizos. 
Completa el espacio en blanco 
para mostrar los nombres de los 
hechizos en la consola:
*/
 
using System;

class Program
{
    static void Main()
    {
        string[] hechizos = { "Expecto Patronum", "Wingardium Levios", "Expelliarmus" };
       
        Console.WriteLine("Bienvenidos a los hechizos de Harry    ");
        Console.WriteLine("       _   _                           ");                       
        Console.WriteLine("      | | | | __ _ _ __ _ __ _   _     ");
        Console.WriteLine("      | |_| |/ _` | '__| '__| | | |    ");
        Console.WriteLine("      |  _  | (_| | |  | |  | |_| |    ");
        Console.WriteLine("      |_| |_|*__,_|_|  |_|   *__, |    ");
        Console.WriteLine("                              |___/    "); 

        Console.WriteLine("Lista de hechizos de Harry Potter:");

        // Hechizos listados
        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine(hechizos[i]);
        }
    }
}