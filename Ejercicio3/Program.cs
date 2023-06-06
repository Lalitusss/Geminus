using System;
using System.Collections.Generic;

namespace Ejercicio3
{
    class Program
    {
        double resultado = 0;
        static int vagones = 3;
        static int capacidad = 141;
  
        class Caja
        {
           public double Ancho { get; set; }
            public double Largo { get; set; }
            public double Profundidad { get; set; }
        }
       public  static void Main(string[] args)
        {
            double totalCapacidad = vagones * capacidad;
            double totalCajas = 0;
            List<Caja> lstCajas = new List<Caja>();
            Caja caja = new Caja();
            Console.WriteLine("Ingreso las medidas de las Cajas para subir al Vagon");

            while (true) { 

                Console.Write("Ingrese Largo Caja: ");
                caja.Largo = double.Parse(Console.ReadLine());
                Console.Write("Ingrese Ancho Caja: ");
                caja.Ancho = double.Parse(Console.ReadLine());
                Console.Write("Ingrese Profundidad Caja: ");
                caja.Profundidad = double.Parse(Console.ReadLine());
                var total = caja.Largo * caja.Ancho * caja.Profundidad;
                totalCajas += total;
                if (totalCajas < totalCapacidad)
                {
                    lstCajas.Add(caja);
                }
                else
                {
                    Console.WriteLine("Excede el limite del Vagon!!!");
                    break;
                }
            }

            Console.WriteLine("Se pudieron cargar " + lstCajas.Count.ToString() + " cajas a los trenes.");


        }
    }
}
