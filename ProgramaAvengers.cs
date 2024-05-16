/******************************************************************************
Autor: Andres Rojas - Matias Florez
Fecha: 16-05.2024
Los avengers necesitan un programa en C# para calcular la fuerza
necesaria para levantar un objeto en el planeta Marte. Completa el
espacio en blanco para solicitar al usuario la masa del objeto a 
levantar:
Formula: Fuerza = masa * gravedad
*******************************************************************************/
using System;
class program
{
  static void Main(string[] args) 
  {
      // Definir la gravedad de marte en m/s*2
  double gravedad = 3.72076;
  
    Console.WriteLine("Ingrese la masa del objeto a levantar en kilogramos:");
    
    /*VARIABLES*/
    double masaObjeto = Convert.ToDouble(Console.ReadLine());
    
    double fuerza = masaObjeto * gravedad;
    
    Console.WriteLine("La fuerza necesaria oara levantar el onjeto es de aproximadamente" + fuerza + "Newtons");
  }
}