/******************************************************************************

Autor: Andres Hernandez
Fecha: 22-05-2024
Descripcion: programa de decisiones para determinar el sexo de un usuario
*******************************************************************************/
using System;
class Programa {
static void Main() {
    // variables
    bool sexoMasculino;
    // capturar informacion del usuario 
    Console.Write("Digite true si es hombre");
    sexoMasculino = Convert.ToBoolean(Console.ReadLine());
    // validacion
    if (sexoMasculino == true)
    {
        Console.WriteLine("Felicidades, es hombre");
    }
    else{
   
    Console.WriteLine("Felicidades es mujer");    
    }
   Console.WriteLine("Finalizada la ejecucion");
  }
} 
