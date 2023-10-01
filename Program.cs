using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlTypes;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Tarea2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcion = 0;
            do
            {
                Console.WriteLine("*********************");
                Console.WriteLine("1-Ejercicio 1");
                Console.WriteLine("2-Ejercicio 2");
                Console.WriteLine("3-Ejercicio 3");
                Console.WriteLine("4-Salir del programa");
                Console.WriteLine("********************");
                Console.WriteLine("Digite su opcion");

                opcion = int.Parse(Console.ReadLine());

                switch (opcion) 
                {
                    case 1: Ejercicio1(); break;
                    case 2: Ejercicio2(); break;
                    case 3: Ejercicio3(); break;
                    case 4: Console.WriteLine("Saliendo del programa");
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Opncion incorrecta sorry");
                        Console.ReadLine(); 
                        break;
                }
                    
            } while (opcion!=4);
            Console.WriteLine();

        }
        static void Ejercicio1()
        {
            float precioPorCamisa=0;
            int cantidadCamisas= 0;
            float costoTotal=0;
            float descuento=0;

            Console.WriteLine($"Bienvenido a la tienda de camisas");
            Console.WriteLine($"Por favor, ingrese la cantidad de camisas que desea comprar: ");

            if (int.TryParse(Console.ReadLine(), out cantidadCamisas))
            {
                Console.Write($"Ingrese el precio de cada camisa: ");

                if (float.TryParse(Console.ReadLine(), out precioPorCamisa))
                {
                    costoTotal = cantidadCamisas * precioPorCamisa;
                    

                    if (cantidadCamisas == 1)
                    {

                    }
                    else if (cantidadCamisas >= 2 && cantidadCamisas <= 5)
                    {
                        descuento = costoTotal * 0.15f;
                    }
                    else if (cantidadCamisas > 5)
                    {
                        descuento = costoTotal * 0.20f;
                    }
                    double costoConDescuento = costoTotal - descuento;

                    Console.WriteLine($"Cantidad de camisas: {cantidadCamisas}");
                    Console.WriteLine($"Precio por camisa: {precioPorCamisa:c}");
                    Console.WriteLine($"Costo total: {costoTotal:c}");
                    Console.WriteLine($"Descuento aplicado: {descuento:c}");
                    Console.WriteLine($"Costo con descuento: {costoConDescuento:c}");
                }
                else
                {
                    Console.WriteLine("El precio ingresado no es válido.");
                }
         
                {
                Console.WriteLine("La cantidad de camisas ingresada no es válida.");
                }
             
            }
        }
        static void Ejercicio2() 
        {
            int carnet;
            string nombre, condicion;
            float[] quices = new float[3];
            float[] tareas = new float[3];
            float[] examenes = new float[3];
            double porcentajeQuices, porcentajeTareas, porcentajeExamenes, promedioFinal;

            Console.WriteLine("Calculadora para promedio de estudiantes");
            Console.Write("Ingrese el carnet del estudiante: ");
            carnet = int.Parse(Console.ReadLine());

            Console.Write("Ingrese el nombre del estudiante: ");
            nombre = Console.ReadLine();

            for (int i = 0; i < 3; i++)
            {
                Console.Write($"Ingrese la calificación del quiz {i + 1}: ");
                quices[i] = float.Parse(Console.ReadLine());

                Console.Write($"Ingrese la calificación de la tarea {i + 1}: ");
                tareas[i] = float.Parse(Console.ReadLine());

                Console.Write($"Ingrese la calificación del examen {i + 1}: ");
                examenes[i] = float.Parse(Console.ReadLine());
            }

            porcentajeQuices = (quices[0] + quices[1] + quices[2]) / 3 * 0.25;
            porcentajeTareas = (tareas[0] + tareas[1] + tareas[2]) / 3 * 0.30;
            porcentajeExamenes = (examenes[0] + examenes[1] + examenes[2]) / 3 * 0.45;
            promedioFinal = porcentajeQuices + porcentajeTareas + porcentajeExamenes;

            
            if (promedioFinal >= 70)
            {
                condicion = "Aprobado";
            }
            else if (promedioFinal >= 50)
            {
                condicion = "Aplazado";
            }
            else
            {
                condicion = "Reprobado";
            }

            
            Console.WriteLine("\nResultados:");
            Console.WriteLine($"Carnet: {carnet}");
            Console.WriteLine($"Nombre: {nombre}");
            Console.WriteLine($"Porcentaje de Quices: {porcentajeQuices:f2}%");
            Console.WriteLine($"Porcentaje de Tareas: {porcentajeTareas:f2}%");
            Console.WriteLine($"Porcentaje de Examenes: {porcentajeExamenes:f2}%");
            Console.WriteLine($"Promedio Final: {promedioFinal:F2}%");
            Console.WriteLine($"Condición del Estudiante: {condicion}");
        }
        static void Ejercicio3()
        {
            int cantidad;
            double precio, total;

            Console.Write("Ingrese la cantidad de artículos: ");
            cantidad = int.Parse(Console.ReadLine());

            if (cantidad <= 10)
            {
                precio = 20;
            }
            else
            {
                precio = 15;
            }
            total = cantidad * precio;

            Console.WriteLine($"Precio por artículo: ${precio:F2}");
            Console.WriteLine($"Total de la venta: ${total:F2}");

        }
    }
}
