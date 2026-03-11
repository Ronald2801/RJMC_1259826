using System;

class Program
{
    static void Main()
    {
        // Entrada
        Console.Write("Ingrese su nombre: ");
        string nombre = Console.ReadLine();

        // Proceso + Salida
        Console.WriteLine("Hola, " + nombre + ". ¡Bienvenido/a al Laboratorio 7!");
        Console.WriteLine();

        // EJERCICIO 1

        // ENTRADA
        int N;

        Console.Write("¿Cuántos números desea sumar?: ");
        N = int.Parse(Console.ReadLine());

        // Validar que N sea mayor a 0
        while (N <= 0)
        {
            Console.Write("Valor inválido. Ingrese un número mayor a 0: ");
            N = int.Parse(Console.ReadLine());
        }

        int contador = 0;
        double suma = 0;

        // PROCESO
        while (contador < N)
        {
            Console.Write("Ingrese número " + (contador + 1) + ": ");
            double numero = double.Parse(Console.ReadLine());

            suma = suma + numero;
            contador++;
        }

        double promedio = suma / N;

        // SALIDA
        Console.WriteLine("Suma total: " + suma);
        Console.WriteLine("Promedio: " + promedio);
        Console.WriteLine();






        //EJERCICIO 2

        // ENTRADA
        int opcion;

        // PROCESO el menú se repite hasta que el usuario elija salir
        do
        {
            Console.WriteLine("----MENU DE CONVERSION----");
            Console.WriteLine("1. Celsius a Fahrenheit");
            Console.WriteLine("2. Fahrenheit a Celsius");
            Console.WriteLine("3. Kilómetros a Millas");
            Console.WriteLine("4. Salir");

            Console.Write("Seleccione una opción: ");
            opcion = int.Parse(Console.ReadLine());
            Console.WriteLine();

            if (opcion == 1)
            {
                // ENTRADA
                Console.Write("Ingrese temperatura en Celsius: ");
                double c = double.Parse(Console.ReadLine());

                // PROCESO
                double f = (c * 9 / 5) + 32;

                // SALIDA
                Console.WriteLine("Resultado: " + f.ToString("0.00") + " °F");
                Console.WriteLine();
            }
            else if (opcion == 2)
            {
                // ENTRADA
                Console.Write("Ingrese temperatura en Fahrenheit: ");
                double f = double.Parse(Console.ReadLine());
                // PROCESO
                double c = (f - 32) * 5 / 9;

                // SALIDA
                Console.WriteLine("Resultado: " + c.ToString("0.00") + " °C");
                Console.WriteLine();
            }
            else if (opcion == 3)
            {
                // ENTRADA
                Console.Write("Ingrese kilómetros: ");
                double km = double.Parse(Console.ReadLine());

                // PROCESO
                double millas = km * 0.621371;

                // SALIDA
                Console.WriteLine("Resultado: " + millas.ToString("0.00") + " millas");
                Console.WriteLine();
            }
            else if (opcion == 4) 
            {
                // SALIDA
                Console.WriteLine("Saliendo del programa...");
                Console.WriteLine();
            }
            else
            {
                // SALIDA
                Console.WriteLine("Opción inválida"); // Si el usuario ingresa una opción no válida o no definida anteriormente se muestra un mensaje de error
                Console.WriteLine();
            }

        } while (opcion != 4);





        //EJERCICIO 3

        Console.WriteLine("----ADIVINA EL NÚMERO----");


        // PROCESO - generar un número aleatorio
        Random random = new Random();
        int numeroSecreto = random.Next(1, 101);

        int num = 0;
        int intentos = 0;

        // PROCESO: repetir hasta que se adivine el numero secreto
        while (num != numeroSecreto)
        {
            // ENTRADA
            Console.Write("Ingrese un número entre 1 y 100: ");
            num = int.Parse(Console.ReadLine());

            // VALIDACIÓN
            if (num < 1 || num > 100)
            {
                Console.WriteLine("Número fuera de rango. Intente de nuevo.");
                continue;
            }

            intentos++;

            // PROCESO + SALIDA
            if (num < numeroSecreto)
            {
                Console.WriteLine("Más alto");
            }
            else if (num > numeroSecreto)
            {
                Console.WriteLine("Más bajo");
            }
        }

        // SALIDA FINAL
        Console.WriteLine("¡Correcto!");
        Console.WriteLine("Número de intentos: " + intentos);
        Console.WriteLine();

        // EJERCICIO 4

        // ENTRADA
        int pinIngresado;

        // PROCESO
        int pinCorrecto = 1234;
        int intentosPin = 0;

        // Ciclo DO-WHILE: se ejecuta al menos una vez
        do
        {
            Console.Write("Ingrese el PIN: ");
            pinIngresado = int.Parse(Console.ReadLine());

            // Validación del PIN
            if (pinIngresado == pinCorrecto)
            {
                // SALIDA
                Console.WriteLine("Acceso concedido");
                Console.WriteLine();
                return; // termina el programa si el PIN es correcto
            }
            else
            {
                Console.WriteLine("PIN incorrecto");
                Console.WriteLine();
                intentosPin++;
            }

        } while (intentosPin < 3);

        // SALIDA FINAL
        Console.WriteLine("Cuenta bloqueada");
    }
}

