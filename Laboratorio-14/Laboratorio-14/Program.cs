using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_14
{
        class Libro 
        {
            public string titulo;
            public string autor;
            public int anioPublicacion;
            public bool disponible;

            public void recibirDatos()
            {
                Console.WriteLine("Ingrese el título del libro:");
                titulo = Console.ReadLine();
                Console.WriteLine("Ingrese el autor del libro:");
                autor = Console.ReadLine();
                Console.WriteLine("Ingrese el año de publicación del libro:");
                anioPublicacion = int.Parse(Console.ReadLine());
                Console.WriteLine("¿El libro está disponible? (true/false):");
                disponible = bool.Parse(Console.ReadLine());
            }

        public void mostrarDatos()
            {
                Console.WriteLine("Título: " + titulo);
                Console.WriteLine("Autor: " + autor);
                Console.WriteLine("Año de Publicación: " + anioPublicacion);
                Console.WriteLine("Disponible: " + disponible);
        }

        public void prestarLibro()
            {
            Console.WriteLine("Desea prestar el libro? (true/false):");
            bool deseaPrestar = bool.Parse(Console.ReadLine());
                if (disponible && deseaPrestar)
                {
                    Console.WriteLine("El libro ha sido prestado.");
                    disponible = false;
                }
                else 
                {
                    Console.WriteLine("El libro no está disponible para prestar.");
                }
        }
        public void devolverLibro()
            {
            Console.WriteLine("Desea devolver el libro? (true/false):");
            bool deseaDevolver = bool.Parse(Console.ReadLine());
                if (!disponible && deseaDevolver)
                {
                    Console.WriteLine("El libro ha sido devuelto.");
                    disponible = true;
                }
                else
                {
                    Console.WriteLine("El libro ya ha sido devuelto en la biblioteca.");
                }
        }
    }

        class Program
        {
            static void Main(string[] args)
            {
                Libro libro1 = new Libro();
                libro1.recibirDatos();
                Console.WriteLine("\nDatos del libro:");
                libro1.mostrarDatos();
                Console.WriteLine("\nIntentando prestar el libro...");
                libro1.prestarLibro();
                Console.WriteLine("\nIntentando prestar el libro nuevamente...");
                libro1.prestarLibro();
                Console.WriteLine("\nDevolviendo el libro...");
                libro1.devolverLibro();
                Console.WriteLine("\nIntentando devolver el libro nuevamente...");
                libro1.devolverLibro();
            }
    }

}

