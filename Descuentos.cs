/*******************************************************************************
Autor: Andres Hernandez 
Fecha: 2024-05-22
Descripcion:
Tony Stark, Iron Man, quiere saber cuanto dinero debe
tener para comprar X tornillos c/u a $300, pero en la tienda
le dan descuentos segun cantidad comprado.
Crear un algoritmo que ayude a calcular si compra C#:
    1 sin descuento, 
    5 descuento del 30%
    10 descuento del 50%

*******************************************************************************/
using System;
class ProgramaDescuentos
{
  static void Main ()
  {

	 // Precio unitario del tornillo
        double precioUnitario = 300;

        // Cantidad de tornillos a comprar
        int cantidad = ObtenerCantidad();

        // Calcular el descuento según la cantidad comprada
        double descuento = CalcularDescuento(cantidad);

        // Calcular el costo total con descuento
        double costoTotal = CalcularCostoTotal(cantidad, precioUnitario, descuento);

        // Mostrar el resultado
        Console.WriteLine("Cantidad de tornillos: " + cantidad);
        Console.WriteLine("Descuento aplicado (%): " + descuento);
        Console.WriteLine("Costo total: $" + costoTotal);
    }

    static int ObtenerCantidad()
    {
        Console.Write("Ingrese la cantidad de tornillos a comprar: ");
        int cantidad = Convert.ToInt32(Console.ReadLine());
        return cantidad;
    }

    static double CalcularDescuento(int cantidad)
    {
        double descuento = 0;
        if (cantidad >= 100)
        {
            descuento = 10; // Descuento del 10% para compras de 100 o más tornillos
        }
        else if (cantidad >= 50)
        {
            descuento = 5; // Descuento del 5% para compras de 50 o más tornillos
        }
        return descuento;
    }

    static double CalcularCostoTotal(int cantidad, double precioUnitario, double descuento)
    {
        double costoTotal = cantidad * precioUnitario;
        costoTotal -= (costoTotal * (descuento / 100)); // Aplicar descuento
        return costoTotal;
    }
}