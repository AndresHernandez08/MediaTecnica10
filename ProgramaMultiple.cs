/*
Autor: Andres Hernandez
Fecha: 29-05-24
Descripcion: Ejercicio estructura de desicison multiple
Se desea un programa que ayude diciendo las preferencias segun el genero:
- Si es un hombre menor de edad sus preferencias son:
     Figuras de accion, caricaturas, series TV
- Si es un hombre mayor de edas sus preferencias son:
     cine, picnic y filantropia
- Si es una mujer menor de edad sus preferencias son:
      muñecas, Maquillaje, Series TV
- Si es una mujer mayor de edas sus preferencias son:
      Maquillaje, Series TV, Cine, filatropia
*/      
using System;
class Program {
   static void Main (string[] args) {
       
       Console.WriteLine("Ingrese su genero (Hombre/Mujer): ");
       string genero = Console.ReadLine();
       
       Console.WriteLine("Ingrese su edad");
       int edad = Int32.Parse(Console.ReadLine());
       
       if (genero == "Hombre"){
           
       if (edad < 18){
       }
         // Preferencias para hombres menores
         Console.WriteLine("Tus preferencias son: Figuras de accion, Caricaturas, Serie de TV.");
       }
       
       else
       {
         // Preferencias para hombres mayores  
         Console.WriteLine("Tus preferencias son: Cine, picnic y filantropia.");
       }
       

  if (genero == "Mujer"){
  }
  if (edad < 18){
  {
      // Preferencias para mujeres menores
      Console.WriteLine(" Tus preferencias son Muñecas, Maquillaje, series de TV.");
      
    }
      // Preferencias para mujeres mayores
      Console.WriteLine(" Maquillaje, Series TV, Cine, filatropia.");
           
           
       }
    }
