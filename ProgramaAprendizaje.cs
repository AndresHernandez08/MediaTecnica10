/******************************************************************************
Autor: Andres Hernandez
Fecha: 30-05-24
Descripcion: Ejercicio aprendizaje

Dada la nota determinar: 
1 - Pierde
2 - Pierde
3 - Gana 
4 - Alto
5 - Superior


*******************************************************************************/
using System;
class Program {
  static void Main() {
    Console.WriteLine("Digite la nota 1.0-5.0), luego enter");
    Console.Write("nota: ");
    int nota = Int32.Parse(Console.ReadLine());
    switch (nota)
    {
        
    case 1:
     Console.WriteLine("Pierdes");
      break;
     
    case 2:
     Console.WriteLine("Pierdes ");
      break;
     
    case 3:
     Console.WriteLine("Ganas");
      break;
     
    case 4:
     Console.WriteLine("Alto");
      break;
     
    case 5:
     Console.WriteLine("Superior");
      break;
     default:
     Console.WriteLine("Opcion no valida");
     Console.WriteLine("Saliendo del programa...");
     break;
    }
  }   
}