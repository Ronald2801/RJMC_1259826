using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_13
{
    //EJERCICIO 1
    class Persona
    {
        public string nombre;
        public int edad;
        public double altura;
        public bool estudiante;
    }

    class Program1
    {
        public static void Ejecutar()
        {
            Persona p = new Persona();

            p.nombre = "Ronald";
            p.edad = 20;
            p.altura = 1.75;
            p.estudiante = true;

            Console.WriteLine("--------PERSONA--------");
            Console.WriteLine("Nombre: " + p.nombre);
            Console.WriteLine("Edad: " + p.edad);
            Console.WriteLine("Altura: " + p.altura);
            Console.WriteLine("Estudiante: " + p.estudiante);
            Console.WriteLine();
        }
    }

    //EJERCICIO 2
    class vehiculo
    {
        public string marca;
        public string modelo;
        public int anio;
        public string color;
        public string placa;
    }

    class Program2
    {
        public static void Ejecutar()
        {
            vehiculo v = new vehiculo();

            v.marca = "BMW";
            v.modelo = "X5M";
            v.anio = 2025;
            v.color = "Negro";
            v.placa = "5BD92G7";

            Console.WriteLine("---------VEHICULO---------");
            Console.WriteLine("Marca: " + v.marca);
            Console.WriteLine("Modelo: " + v.modelo);
            Console.WriteLine("Año: " + v.anio);
            Console.WriteLine("Color: " + v.color);
            Console.WriteLine("Placa: " + v.placa);
            Console.WriteLine();
        }
    }

    //EJERCICIO 3
    class producto
    {
        public string codigo;
        public string nombre;
        public double precio;
        public int stock;
        public bool disponible;
    }

    class Program3
    {
        public static void Ejecutar()
        {
            producto prod1 = new producto();
            producto prod2 = new producto();

            prod1.codigo = "1561078105407841635";
            prod1.nombre = "Azucar";
            prod1.precio = 5.00;
            prod1.stock = 150;
            prod1.disponible = true;

            prod2.codigo = "1561078105407841636";
            prod2.nombre = "Arroz";
            prod2.precio = 4.00;
            prod2.stock = 100;
            prod2.disponible = true;

            Console.WriteLine("---------PRODUCTOS---------");

            Console.WriteLine("Producto 1:");
            Console.WriteLine("Código: " + prod1.codigo);
            Console.WriteLine("Nombre: " + prod1.nombre);
            Console.WriteLine("Precio: " + prod1.precio);
            Console.WriteLine("Stock: " + prod1.stock);
            Console.WriteLine("Disponible: " + prod1.disponible);
            Console.WriteLine();

            Console.WriteLine("Producto 2:");
            Console.WriteLine("Código: " + prod2.codigo);
            Console.WriteLine("Nombre: " + prod2.nombre);
            Console.WriteLine("Precio: " + prod2.precio);
            Console.WriteLine("Stock: " + prod2.stock);
            Console.WriteLine("Disponible: " + prod2.disponible);
            Console.WriteLine();
        }
    }

    //EJERCICIO 4
    class macota
    {
        public string nombre;
        public string especie;
        public int edad;
        public double peso;
        public bool vacunado;
    }

    class Program4
    {
        public static void Ejecutar()
        {
            macota m = new macota();

            m.nombre = "Oso";
            m.especie = "Perro";
            m.edad = 7;
            m.peso = 20.5;
            m.vacunado = true;

            Console.WriteLine("---------MASCOTA---------");
            Console.WriteLine("Nombre: " + m.nombre);
            Console.WriteLine("Especie: " + m.especie);
            Console.WriteLine("Edad: " + m.edad);
            Console.WriteLine("Peso: " + m.peso);
            Console.WriteLine("Vacunado: " + m.vacunado);
            Console.WriteLine();
        }
    }

    class Program
    {
        //Para tener ordenado el codigo, tener cada ejercicio por separado y no perder su funcionalidad, tuve que crear clases separadas para cada ejercicio y al final ejecutarlas todas en un solo Main.
        static void Main()
        {
            Program1.Ejecutar();
            Program2.Ejecutar();
            Program3.Ejecutar();
            Program4.Ejecutar();
        }
    }
}