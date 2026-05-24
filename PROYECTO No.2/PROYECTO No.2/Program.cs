using System;


namespace PROYECTO_No._2
{

class Parcela
        {
            public string tipoCultivo;
            public int mesesCrecimiento;
            public int progreso;
            public bool regada;
            public double ingresos;
            public bool vacia;

            public Parcela()
            {
                tipoCultivo = "Vacía";
                mesesCrecimiento = 0;
                progreso = 0;
                regada = false;
                ingresos = 0;
                vacia = true;
            }
        }

        class Program
        {
            static void Main()
            {
                
                // VARIABLES GENERALES

                double dinero;
                int empleados;
                double sueldoEmpleado;
                int mesesRestantes;
                int filas;
                int columnas;

                double ingresosTotales = 0;
                double egresosTotales = 0;

                int mesesSimulados = 0;
                int totalRiegos = 0;

                int papasSembradas = 0;
                int tomatesSembrados = 0;
                int fresasSembradas = 0;

                int papasCosechadas = 0;
                int tomatesCosechados = 0;
                int fresasCosechadas = 0;

                
                // CONFIGURACIÓN INICIAL
                

                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("GESTIÓN DE GRANJA");
                Console.ResetColor();

                do
                {
                    Console.Write("Dinero inicial: ");
                    dinero = Convert.ToDouble(Console.ReadLine());

                    if (dinero <= 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("ERROR: Debe ser mayor a 0.");
                        Console.ResetColor();
                    }

                } while (dinero <= 0);

                do
                {
                    Console.Write("Número de empleados: ");
                    empleados = Convert.ToInt32(Console.ReadLine());

                    if (empleados <= 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("ERROR: Debe ser mayor a 0.");
                        Console.ResetColor();
                    }

                } while (empleados <= 0);

                do
                {
                    Console.Write("Sueldo por empleado: ");
                    sueldoEmpleado = Convert.ToDouble(Console.ReadLine());

                    if (sueldoEmpleado <= 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("ERROR: Debe ser mayor a 0.");
                        Console.ResetColor();
                    }

                } while (sueldoEmpleado <= 0);

                do
                {
                    Console.Write("Meses por simular: ");
                    mesesRestantes = Convert.ToInt32(Console.ReadLine());

                    if (mesesRestantes <= 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("ERROR: Debe ser mayor a 0.");
                        Console.ResetColor();
                    }

                } while (mesesRestantes <= 0);

                do
                {
                    Console.Write("Cantidad de filas: ");
                    filas = Convert.ToInt32(Console.ReadLine());

                    if (filas <= 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("ERROR: Debe ser mayor a 0.");
                        Console.ResetColor();
                    }

                } while (filas <= 0);

                do
                {
                    Console.Write("Cantidad de columnas: ");
                    columnas = Convert.ToInt32(Console.ReadLine());

                    if (columnas <= 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("ERROR: Debe ser mayor a 0.");
                        Console.ResetColor();
                    }

                } while (columnas <= 0);

                
                // MATRIZ DE PARCELAS
   
                                            
            Parcela[,] parcelas = new Parcela[filas, columnas];

                for (int i = 0; i < filas; i++)
                {
                    for (int j = 0; j < columnas; j++)
                    {
                        parcelas[i, j] = new Parcela();
                    }
                }

                int opcion;

                
                // CICLO PRINCIPAL
                

                while (mesesRestantes > 0 && dinero > 0)
                {
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("------ MENÚ PRINCIPAL ------");
                    Console.ResetColor();

                    Console.WriteLine("1. Sembrar");
                    Console.WriteLine("2. Regar parcelas");
                    Console.WriteLine("3. Consultar parcela");
                    Console.WriteLine("4. Avanzar de mes");
                    Console.WriteLine("5. Salir");

                    Console.Write("Seleccione una opción: ");
                    opcion = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine();


                // OPCIÓN 1: SEMBRAR


                if (opcion == 1)
                    {
                        int fila;
                        int columna;

                        Console.Write("Fila: ");
                        fila = Convert.ToInt32(Console.ReadLine());

                        Console.Write("Columna: ");
                        columna = Convert.ToInt32(Console.ReadLine());

                        fila--;  // Ajuste para que las coordenadas ingresadas por el usuario comiencen en 1
                        columna--;


                    if (fila < 0 || fila >= filas || columna < 0 || columna >= columnas)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("ERROR: Coordenadas inválidas.");
                            Console.ResetColor();
                        }
                        else if (!parcelas[fila, columna].vacia)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("ERROR: La parcela ya está ocupada.");
                            Console.ResetColor();
                        }
                        else
                        {
                            Console.WriteLine("1. Papa");
                            Console.WriteLine("2. Tomate");
                            Console.WriteLine("3. Fresa");

                            int cultivo;
                            Console.Write("Seleccione cultivo: ");
                            cultivo = Convert.ToInt32(Console.ReadLine());

                            if (cultivo == 1)
                            {
                                parcelas[fila, columna].tipoCultivo = "Papa";
                                parcelas[fila, columna].mesesCrecimiento = 2;
                                parcelas[fila, columna].ingresos = 450;
                                parcelas[fila, columna].vacia = false;

                                papasSembradas++;
                            }
                            else if (cultivo == 2)
                            {
                                parcelas[fila, columna].tipoCultivo = "Tomate";
                                parcelas[fila, columna].mesesCrecimiento = 3;
                                parcelas[fila, columna].ingresos = 650;
                                parcelas[fila, columna].vacia = false;

                                tomatesSembrados++;
                            }
                            else if (cultivo == 3)
                            {
                                parcelas[fila, columna].tipoCultivo = "Fresa";
                                parcelas[fila, columna].mesesCrecimiento = 4;
                                parcelas[fila, columna].ingresos = 900;
                                parcelas[fila, columna].vacia = false;

                                fresasSembradas++;
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("ERROR: Cultivo inválido.");
                                Console.ResetColor();
                            }

                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Siembra realizada correctamente.");
                            Console.ResetColor();
                        }
                    }

                 
                    // OPCIÓN 2: REGAR

                    else if (opcion == 2)
                    {
                        int fila;
                        int columna;

                        Console.Write("Fila: ");
                        fila = Convert.ToInt32(Console.ReadLine());

                        Console.Write("Columna: ");
                        columna = Convert.ToInt32(Console.ReadLine());

                        fila--;  // Ajuste para que las coordenadas ingresadas por el usuario comiencen en 1
                        columna--;

                        if (fila < 0 || fila >= filas || columna < 0 || columna >= columnas)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("ERROR: Coordenadas inválidas.");
                            Console.ResetColor();
                        }
                        else if (parcelas[fila, columna].vacia)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("ERROR: La parcela está vacía.");
                            Console.ResetColor();
                        }
                        else if (parcelas[fila, columna].regada)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("ERROR: Ya fue regada este mes.");
                            Console.ResetColor();
                        }
                        else if (dinero < 40)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("ERROR: Dinero insuficiente.");
                            Console.ResetColor();
                        }
                        else
                        {
                            dinero = dinero - 40;
                            egresosTotales = egresosTotales + 40;
                            totalRiegos++;

                            parcelas[fila, columna].regada = true;

                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Parcela regada correctamente.");
                            Console.ResetColor();
                        }
                    }

  
                    // OPCIÓN 3: CONSULTAR PARCELA


                    else if (opcion == 3)
                    {
                        int fila;
                        int columna;

                        Console.Write("Fila: ");
                        fila = Convert.ToInt32(Console.ReadLine());

                        Console.Write("Columna: ");
                        columna = Convert.ToInt32(Console.ReadLine());

                        fila--;  // Ajuste para que las coordenadas ingresadas por el usuario comiencen en 1
                        columna--;

                        if (fila < 0 || fila >= filas || columna < 0 || columna >= columnas)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("ERROR: Coordenadas inválidas.");
                            Console.ResetColor();
                        }
                        else if (parcelas[fila, columna].vacia)
                        {
                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                            Console.WriteLine("Parcela disponible para siembra.");
                            Console.ResetColor();
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.WriteLine("Tipo de cultivo: " + parcelas[fila, columna].tipoCultivo);
                            Console.WriteLine("Crecimiento: " +
                                parcelas[fila, columna].progreso + " / " +
                                parcelas[fila, columna].mesesCrecimiento);

                            Console.WriteLine("Regada este mes: " +
                                (parcelas[fila, columna].regada ? "Sí" : "No"));

                            Console.ResetColor();
                        }
                    }

      
                    // OPCIÓN 4: AVANZAR MES
  

                    else if (opcion == 4)
                    {
                        double pago = empleados * sueldoEmpleado;

                        dinero = dinero + pago;
                        egresosTotales = egresosTotales + pago;

                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Pago de empleados: Q" + pago);
                        Console.ResetColor();

                        for (int i = 0; i < filas; i++)
                        {
                            for (int j = 0; j < columnas; j++)
                            {
                                if (!parcelas[i, j].vacia)
                                {
                                    if (parcelas[i, j].regada)
                                    {
                                        parcelas[i, j].progreso = parcelas[i, j].progreso + 2;
                                    }
                                    else
                                    {
                                        parcelas[i, j].progreso = parcelas[i, j].progreso + 1;
                                    }

                                    if (parcelas[i, j].progreso >= parcelas[i, j].mesesCrecimiento)
                                    {
                                        Console.ForegroundColor = ConsoleColor.Green;

                                        Console.WriteLine(
                                            "Cosecha realizada: " +
                                            parcelas[i, j].tipoCultivo);

                                        Console.ResetColor();

                                        dinero = dinero + parcelas[i, j].ingresos;
                                        ingresosTotales = ingresosTotales + parcelas[i, j].ingresos;

                                        if (parcelas[i, j].tipoCultivo == "Papa")
                                        {
                                            papasCosechadas++;
                                        }
                                        else if (parcelas[i, j].tipoCultivo == "Tomate")
                                        {
                                            tomatesCosechados++;
                                        }
                                        else if (parcelas[i, j].tipoCultivo == "Fresa")
                                        {
                                            fresasCosechadas++;
                                        }

                                        parcelas[i, j] = new Parcela();
                                    }
                                    else
                                    {
                                        parcelas[i, j].regada = false;
                                    }
                                }
                            }
                        }

                        mesesRestantes--;
                        mesesSimulados++;

                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Mes avanzado correctamente.");
                        Console.ResetColor();
                    }

   
                    // OPCIÓN 5: SALIR
         
                    else if (opcion == 5)
                    {
                        break;
                    }

                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("ERROR: Opción inválida.");
                        Console.ResetColor();
                    }
                }

                
                // REPORTE FINAL 

                int parcelasVacias = 0;

                for (int i = 0; i < filas; i++)
                {
                    for (int j = 0; j < columnas; j++)
                    {
                        if (parcelas[i, j].vacia)
                        {
                            parcelasVacias++;
                        }
                    }
                }

                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("----------- REPORTE FINAL -----------");
                Console.ResetColor();

                Console.WriteLine("Dinero final: Q" + dinero);
                Console.WriteLine("Ingresos totales: Q" + ingresosTotales);
                Console.WriteLine("Egresos totales: Q" + egresosTotales);
                Console.WriteLine("Meses simulados: " + mesesSimulados);

                Console.WriteLine();
                Console.WriteLine("     Parcelas sembradas");
                Console.WriteLine("Papas: " + papasSembradas);
                Console.WriteLine("Tomates: " + tomatesSembrados);
                Console.WriteLine("Fresas: " + fresasSembradas);

                Console.WriteLine();
                Console.WriteLine("     Cosechas realizadas");
                Console.WriteLine("Papas: " + papasCosechadas);
                Console.WriteLine("Tomates: " + tomatesCosechados);
                Console.WriteLine("Fresas: " + fresasCosechadas);

                Console.WriteLine();
                Console.WriteLine("Total de riegos: " + totalRiegos);
                Console.WriteLine("Parcelas vacías al finalizar: " + parcelasVacias);

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Programa finalizado.");
                Console.ResetColor();
            }
        }
    }
