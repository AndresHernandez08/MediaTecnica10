/******************************************************************************

Autor:         Andres Hernandez
Fecha:         18 de julio de 2024
Descripción:   Calculadora para frase
               que incluya un menu para ingresar a opcion debe permitir 
               ingresar la frase y luego calcular cantidad de letras que tiene.
*******************************************************************************/

using System;

class Program
{
    static void Main(string[] args)
    {
       
       
       
       
        Console.Write("Ingrese una frase: ");
        
        
        
       
        string frase = Console.ReadLine();
       
       
        int cantidadLetras = frase.Length;
        
        Console.WriteLine($"La frase '{frase}' tiene {cantidadLetras} letras.");
    }
}