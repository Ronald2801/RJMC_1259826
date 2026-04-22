using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_11
{
    internal class Program
    {
        private static int i;

        static void Main(string[] args)
        {

            Console.Write("Ingrese su nombre: ");
            string nombre = Console.ReadLine();

            Console.WriteLine("Bienvenido(a), " + nombre);

            // EJERCICIO 1

            Console.WriteLine("------------------------------------------------------------");

            string pass;
            bool valida = false;

            while (!valida)
            {
                Console.Write("Ingrese contraseña: ");
                pass = Console.ReadLine();

                bool tieneMayuscula = false;
                bool tieneNumero = false;
                bool tieneEspecial = false;

                if (pass.Length < 8)
                {
                    Console.WriteLine();
                    Console.WriteLine("Contraseña inválida: debe tener al menos 8 caracteres");
                    continue;
                }

                int i = 0;

                while (i < pass.Length)
                {
                    char c = pass[i];

                    if (c >= 'A' && c <= 'Z')
                        tieneMayuscula = true;

                    if (c >= '0' && c <= '9')
                        tieneNumero = true;

                    if (c == '@' || c == '#' || c == '$' || c == '%' || c == '.' || c == ' ' || c == '-' || c == '_')
                        tieneEspecial = true;

                    i++;
                }

                if (tieneMayuscula && tieneNumero && tieneEspecial)
                {
                    Console.WriteLine("Contraseña válida");
                    valida = true;
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("Contraseña Inválida:");

                    if (!tieneMayuscula)
                        Console.WriteLine("- Falta mayúscula");

                    if (!tieneNumero)
                        Console.WriteLine("- Falta número");

                    if (!tieneEspecial)
                        Console.WriteLine("- Falta carácter especial");

                    Console.WriteLine();
                }
            }

            Console.WriteLine("------------------------------------------------------------");
            Console.WriteLine();

            // EJERCICIO 2

            Console.WriteLine("-------------------------------------------------------------");
            Console.Write("Ingrese texto: ");
            string texto = Console.ReadLine();

            string invertido = "";

            int x = texto.Length - 1;

            while (x >= 0)
            {
                invertido += texto[x];
                x--;
            }

            Console.WriteLine("Texto invertido: " + invertido);

            Console.WriteLine("-------------------------------------------------------------");
            Console.WriteLine();

            // EJERCICIO 3

            Console.WriteLine("-------------------------------------------------------------");
            Console.Write("¿Cuántos números desea ingresar?: ");
            int n = int.Parse(Console.ReadLine());

            int[] numeros = new int[n];

            int k = 0;
            int suma = 0;

            while (k < n)
            {
                Console.Write("Número " + (k + 1) + ": ");
                numeros[k] = int.Parse(Console.ReadLine());

                suma += numeros[k];
                k++;
            }

            int mayor = numeros[0];
            int menor = numeros[0];

            x = 0;

            while (x < n)
            {
                if (numeros[x] > mayor)
                    mayor = numeros[x];

                if (numeros[x] < menor)
                    menor = numeros[x];

                x++;
            }

            double promedio = (double)suma / n;

            Console.WriteLine();
            Console.WriteLine("Suma = " + suma);
            Console.WriteLine("Promedio = " + promedio);
            Console.WriteLine("Mayor = " + mayor);
            Console.WriteLine("Menor = " + menor);

            Console.WriteLine("-------------------------------------------------------------");
            Console.WriteLine();

            // EJERCICIO 4

            int[] num = new int[8];

            int j = 0;

            while (j < 8)
            {
                Console.Write("Ingrese 8 números:");
                Console.Write("Número " + (j + 1) + ": ");
                num[j] = int.Parse(Console.ReadLine());
                j++;
            }

            bool encontrado = false;
            int posicion = -1;
            do
            {
                Console.WriteLine();
                Console.Write("Número a buscar: ");
                int buscar = int.Parse(Console.ReadLine());

                int z = 0;

                while (z < 8 && !encontrado)
                {
                    if (num[z] == buscar)
                    {
                        encontrado = true;
                        posicion = z;
                    }
                    z++;
                }

                if (encontrado == true)
                    Console.WriteLine("El número sí existe en la posición " + posicion);
                else
                    Console.WriteLine("El número no existe en el arreglo");
            }
            while (encontrado == false);

            Console.WriteLine("-------------------------------------------------------------");
            Console.WriteLine();

            // EJERCICIO 5

            string[] nombres = new string[5];

            int y = 0;

            while (y < 5)
            {
                Console.WriteLine("Ingrese 5 nombres");
                Console.WriteLine("Ingrese nombre " + (y + 1) + ": ");
                nombres[y] = Console.ReadLine();
                y++;
            }

            int contador = 0;
            string masLargo = nombres[0];

            y = 0;

            while (y < 5)
            {
                if (nombres[y].Length > 5)
                    contador++;

                if (nombres[y].Length > masLargo.Length)
                    masLargo = nombres[y];

                y++;
            }

            Console.WriteLine();
            Console.Write("Nombres ingresados: ");

            y = 0;
            while (y < 5)
            {
                Console.Write(nombres[y]);

                if (y < 4)
                    Console.Write(", ");

                y++;
            }

            Console.WriteLine();
            Console.WriteLine("Más de 5 letras: " + contador);
            Console.WriteLine("Nombre más largo: " + masLargo);

            Console.WriteLine("-------------------------------------------------------------");
            
        }

    }

}
