using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("¿Cómo te llamas? ");
            string nombre = Console.ReadLine();
            Console.WriteLine("Hola, " + nombre + " ¡Bienvenido a C#!");
            Console.WriteLine();


# include <iostream>
            using namespace std;

    // Prototipos
    void llenarMatriz(int m[4][4]);
    int sumaFila(int m[4][4], int fila);
    int sumaColumna(int m[4][4], int col);

    int main()
    {
        int m[4][4];

        llenarMatriz(m);

        int fila, col;

        cout << "Ingrese fila (0-3): ";
        cin >> fila;

        cout << "Ingrese columna (0-3): ";
        cin >> col;

        cout << "Suma de fila: " << sumaFila(m, fila) << endl;
        cout << "Suma de columna: " << sumaColumna(m, col) << endl;

        return 0;
    }

    // Procedimiento
    void llenarMatriz(int m[4][4])
    {
        for (int i = 0; i < 4; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                cout << "Elemento [" << i << "][" << j << "]: ";
                cin >> m[i][j];
            }
        }
    }

    // Funciones
    int sumaFila(int m[4][4], int fila)
    {
        int suma = 0;
        for (int j = 0; j < 4; j++)
        {
            suma += m[fila][j];
        }
        return suma;
    }

    int sumaColumna(int m[4][4], int col)
    {
        int suma = 0;
        for (int i = 0; i < 4; i++)
        {
            suma += m[i][col];
        }
        return suma;
    }

}
    }
}
