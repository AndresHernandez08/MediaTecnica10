/*
Autor: Andres Rojas
Fecha: 2024-05-23
Descripcion: 
        Un docente requiere un sistema de notas donde recibe 4 calificaciones
        generando un promedio y luego determinado si gana o pierde.
        Si su promedio es menor a 3 pierde
        Si es mayor gana 
        Si tiene un promedio mayor a 4.5 emitir mensaje: 
        "Felicidades, te has ganado una beca"
*/
using System;

class ProgramaCalificaciones
{
    static void Main(string[] args)
    {
        // calcular el promedio 
        double calificacionuno, calificaciondos, calificaciontres, calificacioncuatro;
        double promedio;

        // calcular notas 
        Console.WriteLine("Ingrese la primera nota:");
        calificacionuno = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Ingrese la segunda nota:");
        calificaciondos = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Ingrese la tercera nota:");
        calificaciontres = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Ingrese la cuarta nota:");
        calificacioncuatro = Convert.ToDouble(Console.ReadLine());

        
        // promedio de las notas 
        promedio = (calificacionuno + calificaciondos + calificaciontres + calificacioncuatro) / 4;
        Console.WriteLine("el promedio es:" + promedio);
        if (promedio < 3)
            Console.WriteLine("Perdiste JAJAJA 😂");
        if (promedio > 4.5)
            Console.WriteLine("Felicidades, te has ganado una beca 😳");
        if (promedio >= 3 && promedio <= 4.5)
            Console.WriteLine("Gananaste 🤠");
            Console.WriteLine("ganaste bro ");
            
    }
}
