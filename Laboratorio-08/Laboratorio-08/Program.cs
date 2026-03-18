using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Entrada de usuario
            Console.Write("¿Cómo te llamas? ");
            string nombre = Console.ReadLine();
            // Salida de datos
            Console.WriteLine("Hola, " + nombre + " ¡Bienvenido a C#!");

            // EJERCICIO 1

            int nota;
            int aprobados = 0;
            int reprobados = 0;
            int ContEstudiantes = 0;
            int Suma = 0;

            while (ContEstudiantes < 10)
            {
                Console.WriteLine("Ingrese la nota " + (ContEstudiantes + 1) + ": ");
                nota = int.Parse(Console.ReadLine());
                Suma = Suma + nota;

                if (nota >= 61)
                    {
                        Console.WriteLine("Aprobado");
                        Console.WriteLine();
                        aprobados++;
                        ContEstudiantes++;
                        nota = 0;
                    }

                else
                    {
                        Console.WriteLine("Reprobado");
                        Console.WriteLine();
                        reprobados ++;
                        ContEstudiantes ++;
                        nota = 0;
                    }
            }

                Console.WriteLine();
                Console.WriteLine("Número total de estudiantes: " + (aprobados + reprobados));
                Console.WriteLine("Promedio de la clase: " + (Suma / 10 ));
                Console.WriteLine("Número de estudiantes aprobados: " + aprobados);
                Console.WriteLine("Numero de estudiantes reprobados: " + reprobados);
                Console.WriteLine();

            //EJERCICIO 2

            int numero;
            int pares = 0;
            int impares = 0;



        }
    }
}

