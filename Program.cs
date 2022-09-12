using System;

namespace tallerMatrices
{
    class TallerMatrices
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            
            int op = 0;
            string dato = "";

            //Console.WriteLine("\nMenu de opciones: ");
            do
            {
                Console.WriteLine("-------------------------------------------------------------");
                Console.WriteLine("Ingrese el numero de la opción a la cual desea ir (1 al 3): ");
                Console.WriteLine("-------------------------------------------------------------");
                dato = Console.ReadLine();

                if (int.TryParse(dato, out op))
                {
                    switch (op)
                    {
                        case 1:
                            Punto1();
                            break;
                        case 2:
                            Punto2();
                            break;
                        case 3:
                            Punto3();
                            break;
                        default:
                            Console.WriteLine("Error, valor fuera de rango");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Error, valor invalido");
                }
            } while ((!(int.TryParse(dato, out op))) || (op < 1 || op > 15));

        }

        /*
            1. Realice un programa que cree una matriz cuadrada de un tamaño X proporcionado
            por el usuario, con datos ingresados por pantalla y muestre la diagonal secundaria
            de la matriz.
         */
        static void Punto1()
        {
            string dato = "";
            int i, f, c, filasyColumnas, k, valor;
            int[,] Matriz;
            bool ok = false;

            //Creando vector, se pregunta por el tamaño
            do
            {
                Console.WriteLine("Ingrese el número de filas y columnas: ");
                dato = Console.ReadLine();

                if (int.TryParse(dato, out filasyColumnas) && (filasyColumnas > 0))
                { 
                        ok = true;
                }
                else
                {
                    Console.WriteLine("Error, ingrese un entero mayor a cero.");
                }
            
            } while (ok == false);

            //k = tamaño vector 
            k = filasyColumnas - 1;
            
            Matriz = new int[filasyColumnas, filasyColumnas];
            
            //llenando matriz
            for (f = 0; f < filasyColumnas; f++)
            {
                for (c = 0; c < filasyColumnas; c++)
                {
                    ok = false;
                    do
                    {
                        Console.WriteLine("Ingrese el valor de la posición: " + f + "," + c);
                        dato = Console.ReadLine();

                        if (int.TryParse(dato, out valor))
                        {
                              ok = true;
                              Matriz[f, c] = valor;  
                        }
                        else
                        {
                            Console.WriteLine("Error, ingrese un entero.");
                        }

                    } while (ok != true);
                }
            }


            Console.WriteLine("\nImprimir vector: ");
            for (f = 0; f < filasyColumnas; f++)
            {
                for (c = 0; c < filasyColumnas; c++)
                {
                    Console.Write(Matriz[f,c] + "\t");
                }
                Console.WriteLine();
            }


            Console.WriteLine("\nLa diagonal secundaria es: ");
            for (i = 0; i < filasyColumnas; i++)
            {
                Console.WriteLine(Matriz[i, k] + " ");
                k--;
            }
        }


        /*
            2. Realice un programa que cree una matriz de 5x5 con datos ingresados por pantalla y muestre el elemento ubicado en la posición central de la matriz.
        */
        static void Punto2()
        {
            string dato = "";
            int f, c, fb, cb, valor;
            int[,] Matriz = new int[5, 5];
            bool ok = false;

            //creando vector, se pregunta por el tamaño
            for (f = 0; f < 5; f++)
            {
                for (c = 0; c < 5; c++)
                {

                    ok = false;
                    do
                    {
                        Console.WriteLine("Ingrese el valor de la posición: " + f + "," + c);
                        dato = Console.ReadLine();

                        if (int.TryParse(dato, out valor))
                        {
                            ok = true;
                            Matriz[f, c] = valor;
                        }
                        else
                        {
                            Console.WriteLine("Error, ingrese un entero.");
                        }

                    } while (ok != true);

                }
            }

            //Codigo para buscar p posicion en la matriz, como ya no hace falta se comenta por si se necesita después xde
            //preguntaba por fila y columna
            /*
            ok = false;
            do
            {
                Console.WriteLine("A continuación, digite el valor de la fila a buscar: ");
                dato = Console.ReadLine();

                if (int.TryParse(dato, out fb))
                {
                    if (fb >= 0 && fb <= 4)
                    {
                        ok = true;
                    }
                }
                
                if(ok == false)
                {
                    Console.WriteLine("Error, ingrese un numero entre 0 y 4");
                }

            } while (ok != true);
            

            ok = false;
            do
            {
                Console.WriteLine("A continuación, digite el valor de la columna a buscar: ");
                dato = Console.ReadLine();

                if (int.TryParse(dato, out cb))
                {
                    if (cb >= 0 && cb <= 4)
                    {
                        ok = true;
                    }
                }

                if (ok == false)
                {
                    Console.WriteLine("Error, ingrese un numero entre 0 y 4");
                }

            } while (ok != true);
            */


            Console.WriteLine("\nImprimir vector: ");
            for (f = 0; f < Matriz.GetLength(0); f++)
            {
                for (c = 0; c < Matriz.GetLength(1); c++)
                {
                    Console.Write(Matriz[f, c] + "\t");
                }
                Console.WriteLine();
            }


            Console.WriteLine("\nEl valor de la matriz, ubicado en la posición central del vector es: " + Matriz[2, 2]);
        }


        /*
         3. Realice un programa que cree una matriz de 6x3 con datos ingresados por pantalla
            y hallar lo siguiente:  
            ○ ¿Cuántos números se encuentran repetidos?
            ○ ¿Cuántos números son primos?
            ○ ¿Cuántos números son múltiplos de 5?
         */

        static void Punto3()
        {
            int[,] Matriz = new int[6, 3];
            bool[,] matrizBool = new bool[6,3];
            string dato = "";
            int f, c, fb, cb, valor, cantRep = 0, contadorDiv = 0, cantPrimos = 0, cantMult5 = 0;
            bool ok = false;


            //llenando vector
            for (f = 0; f < Matriz.GetLength(0); f++)
            {
                for (c = 0; c < Matriz.GetLength(1); c++)
                {
                    ok = false;
                    do
                    {
                        Console.WriteLine("Ingrese el valor de la posición: " + f + "," + c);
                        dato = Console.ReadLine();

                        if (int.TryParse(dato, out valor))
                        {
                            ok = true;
                            Matriz[f, c] = valor;
                        }
                        else
                        {
                            Console.WriteLine("Error, ingrese un entero.");
                        }

                    } while (ok != true);

                }
            }


            //imprimiendo vector
            Console.WriteLine("\nImprimir vector: ");
            for (f = 0; f < Matriz.GetLength(0); f++)
            {
                for (c = 0; c < Matriz.GetLength(1); c++)
                {
                    Console.Write(Matriz[f, c] + "\t");
                }
                Console.WriteLine();
            }

            /*
            //vector booleano
            //sirve para que marque los que están repetidos para evitar que los vuelva a contar
            Console.WriteLine("\nImprimir vector: ");
            for (f = 0; f < matrizBool.GetLength(0); f++)
            {
                for (c = 0; c < matrizBool.GetLength(1); c++)
                {
                    Console.Write(matrizBool[f, c] + "\t");
                }
                Console.WriteLine();
            }
            */

            //cantidad numeros repetidos
            for (f = 0; f < Matriz.GetLength(0); f++)
            {
                for (c = 0; c < Matriz.GetLength(1); c++)
                {
                    for (int i = 0; i < Matriz.GetLength(0); i++)
                    {
                        for (int j = 0; j < Matriz.GetLength(1); j++)
                        {
                            if (Matriz[f, c] == Matriz[i, j] && (c != j))
                            {
                                if (matrizBool[i, j] == false)
                                {
                                    matrizBool[i, j] = true;
                                    cantRep++;
                                }
                            }
                        }
                    }
                }
            }

            //Cantidad numeros primos y cantidad numeros multiplos de 5
            for (f = 0; f < Matriz.GetLength(0); f++)
            {
                for (c = 0; c < Matriz.GetLength(1); c++)
                {
                    
                    contadorDiv = 0;
                    //ver si hay primos
                    for (int i = 2; i <= (Matriz[f, c] - 1); i++)
                    {
                        if (Matriz[f, c] % i == 0)
                        {
                            contadorDiv++;
                        }
                    }

                    //ir incrementando si existe numeros primos
                    if (contadorDiv == 0 && (Matriz[f,c] > 1))
                    {
                        cantPrimos++;
                    }

                    //ir incrementando si existe numeros multiplos de 5
                    if (Matriz[f, c] % 5 == 0)
                    {
                        cantMult5++;
                    }
                }
            }


            
            Console.WriteLine("Cantidad números primos: " + cantPrimos);
            Console.WriteLine("Cantidad números multiplos de 5: " + cantMult5);
            Console.WriteLine("Cantidad rep: " + cantRep);

        }
    }
}
