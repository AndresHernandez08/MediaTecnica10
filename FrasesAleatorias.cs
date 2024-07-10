/*
Autor: Andres Felipe Hernandez
Fecha: 10/07/2024
Descripcion: Un cliente solicita una mini app en consola que imprima frases
de forma aleatoria cada que es ejecutado

*/
using System;
class MiSegundoVector {
  static void Main() {
      string[] frases = { 
      "Nunca es demasiado tarde para ser lo que podrias haber sido",
      "Aprender de los errores es de sabios", 
      "La adversidad te hace reconocerte a ti mismo",
      "Si es si",
      "No es No"
      };
     
     // aleatorio
     Random aleatorio = new Random ();
     int posicion = aleatorio.Next( 0,5);
     
     // imprimir frase aleatoria
     Console.WriteLine(frases[posicion]);
     }
  }   