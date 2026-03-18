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
                    reprobados++;
                    ContEstudiantes++;
                    nota = 0;
                }
            }

            Console.WriteLine();
            Console.WriteLine("Número total de estudiantes: " + ContEstudiantes);
            Console.WriteLine("Promedio de la clase: " + (Suma / 10));
            Console.WriteLine("Número de estudiantes aprobados: " + aprobados);
            Console.WriteLine("Numero de estudiantes reprobados: " + reprobados);
            Console.WriteLine();

            //EJERCICIO 2

            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("Ingrese un número: ");
            int Num = int.Parse(Console.ReadLine());

            int i = 1;
            int SumaNumeros = 0;
            int pares = 0;
            int impares = 0;

            while (i <= Num)
            {
                SumaNumeros += i;

                if (i % 2 == 0)
                    pares++;
                else
                    impares++;

                i++;
            }

            Console.WriteLine("Suma: " + SumaNumeros);
            Console.WriteLine("Pares: " + pares);
            Console.WriteLine("Impares: " + impares);
            Console.WriteLine();

            //EJERCICIO 3

            Console.WriteLine("-----------------------------------------");

            int opcion;
            double totalVentas = 0;
            int clientes = 0;

            // Ciclo de Menú
            do
            {
                Console.WriteLine("----- MENU DE TIENDA -----");
                Console.WriteLine("1. Registrar compra");
                Console.WriteLine("2. Mostrar total de ventas");
                Console.WriteLine("3. Mostrar cantidad de clientes");
                Console.WriteLine("4. Salir");

                Console.Write("Seleccione una opción: ");
                opcion = int.Parse(Console.ReadLine());
                Console.WriteLine();

                // PROCESO + SALIDA
                if (opcion == 1)
                {
                    Console.Write("Ingrese el monto de la compra: ");
                    double monto = double.Parse(Console.ReadLine());

                    totalVentas += monto;
                    clientes++;

                    Console.WriteLine("Compra registrada correctamente.");
                    Console.WriteLine();
                }
                else if (opcion == 2)
                {
                    Console.WriteLine("Total de ventas: " + totalVentas);
                    Console.WriteLine();
                }
                else if (opcion == 3)
                {
                    Console.WriteLine("Cantidad de clientes atendidos: " + clientes);
                    Console.WriteLine();
                }
                else if (opcion == 4)
                {
                    Console.WriteLine("Saliendo del sistema...");
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("Opción inválida.");
                    Console.WriteLine();
                }

            } while (opcion != 4);


            //EJERCICIO 4

            Console.WriteLine("-----------------------------------------");

            int numero;
            int total = 0;
            int positivos = 0;
            int negativos = 0;
            int SumaNum = 0;

            do
            {
                Console.Write("Ingrese número (0 para salir): ");
                numero = int.Parse(Console.ReadLine());
                Console.WriteLine();

                if (numero != 0)
                {
                    total++;
                    SumaNum += numero;

                    if (numero > 0)
                        positivos++;
                    else
                        negativos++;
                }

            } while (numero != 0);

            Console.WriteLine("Cantidad: " + total);
            Console.WriteLine("Positivos: " + positivos);
            Console.WriteLine("Negativos: " + negativos);
            Console.WriteLine("Suma: " + SumaNum);
            Console.WriteLine();


            //EJERCICIO 5

            Console.WriteLine("-----------------------------------------");

            Console.Write("Ingrese un número: ");
            int N = int.Parse(Console.ReadLine());

            int a = 1;

            while (a <= N)
            {
                int j = 1;

                while (j <= a)
                {
                    Console.Write(j);
                    j++;
                }

                    Console.WriteLine();
                    a++;

            }
        }
    }
}

