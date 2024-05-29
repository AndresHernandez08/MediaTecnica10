/******************************************************************************
Autor: Andres Hernandez
Fecha: 29-05-2024
Descripcion: App con menu 

Se socilicita crear una minicalculadora que realice:
 -Suma 
 -Resta
 -Multiplicacion
 -Division 
 Debe terminar la ejecucion al usuario elegir opcion "Salir"

*******************************************************************************/
using System;
using System.Threading;
class Program {
  static void Main (string[] args) {
    // Pantalla bienvenida (Imagen ASCII)
    
  Console.WriteLine(" ___ _   _ _ __ ___   __ _ ");                                      
  Console.WriteLine("/ __| | | | '_ ` _ ° / _`  ");                                     
  Console.WriteLine("°__ ° |_| | | | | | | (_| |");                                   
  Console.WriteLine("|___/°__,_|_| |_| |_|°__,_|");                                     
  Console.WriteLine(" _ __ ___  ___| |_ __ _    ");                                     
  Console.WriteLine("| '__/ _ °° __| __/ _` |   ");                                        
  Console.WriteLine("| | |  __/°__ ° | _| |     ");                                   
  Console.WriteLine("|_|  °___| ___/°__°__,_|       _ _                _         ");    
  Console.WriteLine(" _ __ ___  _   _| | |_(_)_ __ | (_) ___ __ _  ___(_) ___  _ __ "); 
  Console.WriteLine("| '_ ` _ °° | | | | __| | '_ °° | |/ __/ _` |/ __| |/ _ °° '_  ° ");
  Console.WriteLine("| | | | | | |_| | | |_| | |_) | | | (_| (_| | (__| | (_) | | | | ");
  Console.WriteLine("|_| |_|_|_|°__,_|_|°__|_| .__/|_|_|°___°__,_|°___|_|°___/|_| |_| ");
  Console.WriteLine("  __| (_)_   _(_)___(_) |_|  _ __                               ");
  Console.WriteLine(" / _` | ° ° / / / __| |/ _ °| '_ °                              ");
  Console.WriteLine("| (_| | |° V /| °__ ° | (_) | | | |                             ");
  Console.WriteLine(" °__,_|_| °_/ |_|___/_|°___/|_| |_|                             ");
  Console.WriteLine("       Bienvenido a la Minicalculadora "); 
  Thread.Sleep(3000); // 3 segundos = 3000 milisegundos
  Console.Clear();
    
    // Mostrar el menu de opciones
    Console.WriteLine("Menu de opciones");
    Console.WriteLine("Seleccionar la opcion deseada");
    Console.WriteLine("1. Suma");
    Console.WriteLine("2. Resta");
    Console.WriteLine("3. Multiplicacion");
    Console.WriteLine("4. Division");
    Console.WriteLine("5. Salir");
    
    // Capturar opcion elegida por el usuario
    Console.Write("Digitar numero deseado: ");
    int opcion = Int32.Parse(Console.ReadLine());
    if (opcion ==5){
        goto Salir;
    
    }
    
    // capturar los numeros elegidos por el usuario
     Console.WriteLine("\nDigitar numero 1: ");
    int numero1 = Int32.Parse(Console.ReadLine());
     Console.WriteLine("\nDigitar numero 2: ");
    int numero2 = Int32.Parse(Console.ReadLine());
    
    // Validar opcion elegida
    if (opcion == 1){
       Console.WriteLine("La suma es: " + (numero1+numero2));
    }
    if (opcion == 2){
       Console.WriteLine("La Resta es: " + (numero1-numero2));   
    }
    if (opcion == 3){
       Console.WriteLine("La Multiplicacion es: " + (numero1*numero2));
    }  
    
    if (opcion == 4){
        if (numero1 != 0 && numero2 !=0){
       Console.WriteLine("La Division es: " + (numero1/numero2));    
    }
    else{
        Console.WriteLine("No se puede dividir por cero."); 
       }
    }    
    // Mostrar el resultado final o ejecucion 
 Salir:
    Console.WriteLine("Saliendo del programa...");


  }
}  
