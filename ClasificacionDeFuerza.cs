

/******************************************************************************

Autor: Andres Hernandez
Fecha: 2024-06-05
Descripcion: El Rey Leon:
        Las manadas de la roca del rey estan compitiendo
        por el control de las Tierras del Reino.
        Pide al usuario la fuerza de al menos 5
        clanes diferentes y usa estructuras "si"
        para determinar clasificacion de fuerza.

*******************************************************************************/
using System;

class HelloWorld {
   
  static void Main(string[] args) {
     
    // variables
    int fuerza = 0;
   
   
   
    Console.WriteLine("Bienvenido a miniApp para fuerza.");
   
   
    for (int i = 0; i <= 4; i++ )
    {
        Console.WriteLine("\nIngrese su numero de fuerza del 1 al 5 " + " y luego presionar enter");
        fuerza =  Int32.Parse(Console.ReadLine());
   
    if (fuerza == 5){
        Console.WriteLine("\nRey leon");
    }
        if (fuerza == 4){
       
            Console.WriteLine("\nTigre");
       }
            if (fuerza == 3){
                Console.WriteLine("\nGorila");
           }
                if (fuerza == 2){
                    Console.WriteLine("\nMonos");
               }
                    if (fuerza == 1){
                        Console.WriteLine("\nSimba");
    }
    }
   
  }
}