using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double consumo, descuento, impuesto, subtotal, importe;
            Console.WriteLine("Ingrese su consumo total: ");
            consumo = double.Parse(Console.ReadLine());
            if (consumo <= 100) ; 
            { 
                descuento = consumo * 0.1;
                impuesto = consumo * 0.18;
                subtotal = consumo - descuento;
                importe = consumo - descuento + impuesto;
            }
            if (consumo > 100); 
            {
                descuento = consumo * 0.2;
                impuesto = consumo * 0.18;
                subtotal = consumo - descuento;
                importe = consumo - descuento + impuesto;
            }
            Console.WriteLine("******************************");
            Console.WriteLine("los montos totales son: ");
            Console.WriteLine("******************************");
            Console.WriteLine($"{descuento} de descuento");
            Console.WriteLine($"{impuesto} de impuesto");
            Console.WriteLine($"Un sub total de {subtotal}");
            Console.WriteLine($"El importe total seria de {importe}");
            Console.WriteLine("******************************");
            Console.ReadKey();
        }
    }
}
