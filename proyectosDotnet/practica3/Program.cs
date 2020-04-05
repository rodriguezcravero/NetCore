using System;
using System.Collections;

namespace practica3
{
    class Program
    {

        // static void ImprimirMatriz(double[,] matriz)
        //     {
        //         int filas = matriz.GetLength(0);
        //         int columnas = matriz.GetLength(1);

        //         for(int i = 0; i < filas; i++)
        //         {
        //             for (int j = 0; j < columnas; j++)
        //             {
        //                 // Console.Write($"{matriz[i,j]:0.00}, ");
        //                 Console.Write($"{matriz[i,j]:0}, ");
        //             }
        //             Console.WriteLine("-");
        //         }
        //     }

        //     static void ImprimirMatriz(double[,] matriz, string formatString)
        //     {
        //         int filas = matriz.GetLength(0);
        //         int columnas = matriz.GetLength(1);

        //         for(int i = 0; i < filas; i++)
        //         {
        //             for (int j = 0; j < columnas; j++)
        //             {
        //                 string res = String.Format(formatString, matriz[i,j]);
        //                 Console.Write(res);
        //             }
        //             Console.WriteLine("-");
        //         }
        //     }

        static void Main(string[] args)
        {

            /*EJERCICIO 1*/

            // Console.CursorVisible = false;
            // ConsoleKeyInfo k = Console.ReadKey(true);

            // while(k.Key != ConsoleKey.End)
            // {
            //     Console.Clear();
            //     Console.Write($"{k.Modifiers}-{k.Key}{k.KeyChar}");
            //     k = Console.ReadKey(true);
            // }

            /*EJERCICIO 2*/

            // double[,] matriz = new double[,]   {{1.1,2.22222,3.3,4.4}, 
            //                                     {5.5, 6.6, 7.777, 8.8},
            //                                     {9.9,10.1,11.1,12.1}};
            
            // // Console.WriteLine(matriz.GetLength(0)); devuelve filas
            // // Console.WriteLine(matriz.GetLength(1)); devuelve columnas
            
            // string s = " - #{0:0.000} - ";

            // ImprimirMatriz(matriz);
            
            /*EJERCICIO 3*/

            //ImprimirMatriz(matriz, s);

            //Métodos implementados fuera del main

            /*EJERCICIO 4*/

            // double[,] matriz = new double[,] {
            //                             {1, 2, 3, 4},
            //                             {5, 6, 7, 8},
            //                             {9, 10, 11, 12},
            //                             {13, 14, 15, 16}
            //                             };

            // double[,] matrizRectangular = new double[,] {
            //                             {1, 2, 3, 4},
            //                             {5, 6, 7, 8},
            //                             {9, 10, 11, 12}
            //                             };

            

            // static double[] GetDiagonalPrincipal(double[,] matriz)
            // {
            //     double [] vacio = null;
            //     try
            //     {
            //         return funcion(matriz);
            //     }
            //     catch(ArgumentException e)
            //     {
            //         Console.WriteLine(e.Message);
            //         return vacio;
            //     }

            //     static double[] funcion(double[,] matriz)
            //     {
            //         int filas = matriz.GetLength(0);
            //         int columnas = matriz.GetLength(1);

            //         if(filas != columnas)
            //         {
            //             throw new ArgumentException("\n La matriz no es cuadrada \n");
            //         }

            //         double[] diagonalSecundaria = new double[filas];

            //         for (int i = 0; i < filas; i++)
            //         {
            //             diagonalSecundaria[i] = matriz[i, i];
            //         }
                    
            //         foreach (double item in diagonalSecundaria)
            //         {
            //             Console.Write($"{item}, ");
            //         }
            //         return diagonalSecundaria;
            //     }
            // }

            // static double[] GetDiagonalSecundaria(double[,] matriz)
            // {
            //     double [] vacio = null;
            //     try
            //     {
            //         return funcion2(matriz);
            //     }
            //     catch(ArgumentException e)
            //     {
            //         Console.WriteLine(e.Message);
            //         return vacio;
            //     }

            //     static double[] funcion2(double[,] matriz)
            //     {
            //         int filas = matriz.GetLength(0);
            //         int columnas = matriz.GetLength(1);

            //         if(filas != columnas)
            //         {
            //             throw new ArgumentException("\n La matriz no es cuadrada \n");
            //         }

            //         double[] diagonalSecundaria = new double[columnas];
            //         int pos = 0;

            //         for (int i = columnas-1; i >= 0; i--)
            //         {
            //             diagonalSecundaria[pos] = matriz[pos, i];
            //             pos++;
            //         }

            //         foreach (double item in diagonalSecundaria)
            //         {
            //             Console.Write($"{item}, ");
            //         }
            //         return diagonalSecundaria;
            //     }
            // }

            // GetDiagonalPrincipal(matriz);
            // GetDiagonalPrincipal(matrizRectangular);
            // GetDiagonalSecundaria(matriz);
            // GetDiagonalSecundaria(matrizRectangular);

            /*EJERCICIO 5*/

            // double[,] matrizRectangular = new double[,] {
            //                             {1, 2, 3, 4},
            //                             {5, 6, 7, 8},
            //                             {9, 10, 11, 12}
            //                             };

            // static double[][] GetArregloDeArreglo(double[,] matriz)
            // {
            //     int filas = matriz.GetLength(0);
            //     int columnas = matriz.GetLength(1);

            //     double[][] arr = new double[filas][];

            //     for (int i = 0; i < filas; i++)
            //     {
            //         arr[i] = new double[columnas];

            //         for (int j = 0; j < columnas; j++)
            //         {
            //             arr[i][j] = matriz[i, j];
            //         }
            //     }

            //     return arr;

            // }

            // double[][] res = GetArregloDeArreglo(matrizRectangular);

            // Console.WriteLine(res[1][3]); // 8
            // Console.WriteLine(res[2][1]); // 10
            // Console.WriteLine(res[2][2]); // 10

            /*EJERCICIO 6*/

            // double[,] matrizA = new double[,] {
            //                                             {2, 0, 1},
            //                                             {3, 0, 0},
            //                                             {5, 1, 1}
            //                                             };

            // double[,] matrizB = new double[,] {
            //                                             {1, 0, 1},
            //                                             {1, 2, 1},
            //                                             {1, 1, 0}
            //                                             };

            // static double[,] Suma(double[,] A, double[,] B)
            // {
            //     int filasA = A.GetLength(0);
            //     int columnasA = A.GetLength(1);
            //     int filasB = B.GetLength(0);
            //     int columnasB = B.GetLength(1);

            //     double[,] matrizRespuesta = new double[filasA, columnasA];

            //     if( (filasA != filasB) && (columnasA != columnasB))
            //     {
            //         return null;
            //     }
            //     else
            //     {
            //         for (int i = 0; i < filasA; i++)
            //         {
            //             for (int j = 0; j < columnasA; j++)
            //             {
            //                 matrizRespuesta[i, j] = A[i, j] + B[i, j];
            //             }
            //         }
            //         return matrizRespuesta;
            //     }
            // }

            // static double[,] Resta(double[,] A, double[,] B)
            // {
            //     int filasA = A.GetLength(0);
            //     int columnasA = A.GetLength(1);
            //     int filasB = B.GetLength(0);
            //     int columnasB = B.GetLength(1);

            //     double[,] matrizRespuesta = new double[filasA, columnasA];

            //     if( (filasA != filasB) && (columnasA != columnasB))
            //     {
            //         return null;
            //     }
            //     else
            //     {
            //         for (int i = 0; i < filasA; i++)
            //         {
            //             for (int j = 0; j < columnasA; j++)
            //             {
            //                 matrizRespuesta[i, j] = A[i, j] - B[i, j];
            //             }
            //         }
            //         return matrizRespuesta;
            //     }
            // }


            // static double[,] Multiplicacion(double[,] A, double[,] B)
            // {
            //     try
            //     {
            //         return Multi(A, B);
            //     }
            //     catch(ArgumentException e)
            //     {
            //         Console.WriteLine(e.Message);
            //         return null;
            //     }

            //     static double[,] Multi(double[,] A, double[,] B)
            //     {
            //         int filasA = A.GetLength(0);
            //         int columnasA = A.GetLength(1);
            //         int filasB = B.GetLength(0);
            //         int columnasB = B.GetLength(1);

            //         if(columnasA != filasB)
            //         {
            //             throw new ArgumentException("\n La matrices no son compatibles para multiplicar \n");
            //         }

            //         double[,] matrizRespuesta = new double[filasA, columnasB];

            //         for (int i = 0; i < filasA; i++)
            //         {
            //             for (int j = 0; j < columnasB; j++)
            //             {
            //                 double temp = 0;
            //                 for (int k = 0; k < columnasA; k++)
            //                 {
            //                     temp += A[i, k] * B[k, j];
            //                 }
            //                 matrizRespuesta[i, j] = temp;
            //             }
            //         }

            //         return matrizRespuesta;

            //     }
            // }

            // // double[,] m = Suma(matrizA, matrizB);

            // // ImprimirMatriz(m);

            // // Console.WriteLine("\n\n");

            // // m = Resta(matrizA, matrizB);

            // // ImprimirMatriz(m);

            // // Console.WriteLine("\n\n");

            // double[,] matrizX = new double[,] {
            //                                             {1, -1, 1},
            //                                             {2, 2, 3},
            //                                             {-2, -3, -1}
            //                                             };

            // double[,] matrizY = new double[,] {
            //                                             {1, 0, 4},
            //                                             {0, 2, 5}
            //                                             };

            // double[,] m = Multiplicacion(matrizX, matrizY);

            // ImprimirMatriz(m);

            /*EJERCICIO 7*/

            // int i = 10;
            // var x = i * 1.0;  // => System.Double
            // var y = 1f;  // => System.Single
            // var z = i * y; // => System.Single

            // Console.WriteLine($"X es de tipo {x.GetType()}, Y es de tipo {y.GetType()},y Z es de tipo {z.GetType()}");

            /*EJERCICIO 8*/

            // var a = 3L; // ok
            // dynamic b = 32; // ok
            // object obj = 3; // ok

            // //a = a * 2.0; //No se puede de long a double, ya existe una conversion implicita

            // b = b * 2.0; // ok
            // b = "hola"; // ok
            // obj = b; // ok, obj=> "hola"
            // b = b + 11; // ok, b => "hola11"
            
            // //obj = obj + 11; // No se puede usar el + entre object e int

            // var c = new {Nombre = "Juan"};
            // var d = new {Nombre = "María"};
            // var e = new {Nombre = "María", Edad = 20};
            // var f = new {Edad = 20, Nombre = "María"};

            // // f.Edad = 22; //Solo lectura??

            // d = c; // ok
            // // e = d; // No se puede pasar un elemento de String a uno de String e Int

            // // f = e; // Lo mismo, de string, int a int, string no se puede

            /*EJERCICIO 9*/

            // object obj = new int[10];

            // dynamic dyn = 13;

            // Console.WriteLine(obj.Lenght); //Error de compilacion, no hay propiedad Length en los array 

            // Console.WriteLine(dyn.Lenght); //Error en tiempo de ejecucion, porque al ser Dynamic no chequea tipo, pero un entero no posee propiedad Length

            /*EJERCICIO 10*/

            // double a = 2.257;
            // double b = 9.999;
            // double c = 7.777;

            // Console.WriteLine("Valor de A: {0:0.0}, B: {1:0.00}, C: {2:0.00}.", a, b, c);
            // Console.WriteLine();
            // Console.WriteLine($"Valor de A: {a:0.0}, B: {b:0.00}, C: {c:0.00000}.");

            /*EJERCICIO 11*/

            // ArrayList a = new ArrayList() {1, 2, 3, 4};

            // a.Remove(5);
            // a.RemoveAt(5); //Fuera de rango

            /*EJERCICIO 12 */

            // char[] arr = new char[] {'0', 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'Ñ', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z', ' '};

            // Queue cola = new Queue();

            // cola.Enqueue(5); 
            // cola.Enqueue(3); 
            // cola.Enqueue(9); 
            // cola.Enqueue(7);

            // static string cifrar(char[] arr, string mensaje, Queue cola)
            // {
            //     char[] localArr = mensaje.ToCharArray();
            //     string str = "";

            //     foreach(char letra in localArr)
            //     {
            //         int pos = Array.IndexOf(arr, letra);
            //         int cifra = (int)cola.Dequeue();
            //         pos += cifra;
            //         if(pos > 28)
            //         {
            //             pos -= 28;
            //         }
            //         str += arr[pos];
            //         cola.Enqueue(cifra);
            //     }
            //     return str;
            // }

            // static string descifrar(char[] arr, string mensaje, Queue cola)
            // {
            //     char[] localArr = mensaje.ToCharArray();
            //     string str = "";

            //     foreach(char letra in localArr)
            //     {
            //         int pos = Array.IndexOf(arr, letra);
            //         int cifra = (int)cola.Dequeue();
            //         pos -= cifra;
            //         if(pos < 1)
            //         {
            //             pos += 28;
            //         }
            //         str += arr[pos];
            //         cola.Enqueue(cifra);
            //     }
            //     Console.WriteLine(str);
            //     return str;
            // }

            // //cifrar(arr, "HOLA MUNDO", cola);
            // descifrar(arr, "MRTHEOCTIR", cola);

            /*EJERCICIO 13*/

            // string str = "x + (a + b) =((((())))))";

            // static void comprobarExpresion(string str)
            // {
            //     Stack pila = new Stack();
            //     char[] arr = str.ToCharArray();

            //     foreach(char caracter in arr)
            //     {
            //         if(caracter == '(')
            //         {
            //             pila.Push(caracter);
            //         }
            //         if(caracter == ')')
            //         {
            //             if(pila.Count == 0)
            //             {
            //                 Console.WriteLine("Expresion erronea");
            //                 return;
            //             }
            //             else
            //             {
            //                 char parentesis = (char)pila.Pop();
            //                 if(parentesis != '(')
            //                 {
            //                     Console.WriteLine("Expresion erronea");
            //                     return;
            //                 }
            //             }
            //         }
            //     }

            //     if(pila.Count == 0)
            //     {
            //         Console.WriteLine("La expresion es correcta");
            //     }
            //     else
            //     {
            //          Console.WriteLine("Expresion erronea");

            //         while(pila.Count > 0)
            //         {
            //             pila.Pop();
            //         }
            //     }
            // }

            // comprobarExpresion(str);

            /*EJERCICIO 14*/
            
            // static void pasarABinario(int num)
            // {
            //     Stack pila = new Stack();

            //     while(num > 0)
            //     {
            //         if(num % 2 == 0)
            //         {
            //             pila.Push(0);
            //         }
            //         else
            //         {
            //             pila.Push(1);
            //         }
            //         num /= 2;
            //     }

            //     while(pila.Count > 0)
            //     {
            //         Console.Write(pila.Pop());
            //     }
            // }

            // pasarABinario(35);

            /*EJERCICIO 15*/

            // int x = 0;

            // try
            // {
            //     Console.WriteLine(1.0 / x); // Devuelve infinito
            //     Console.WriteLine(1 / x); // Error "Division por cero"
            //     Console.WriteLine("todo ok");
            // }
            // catch(Exception e)
            // {
            //     Console.WriteLine(e.Message);
            // }

            // //Respuesta: en el caso de los doubles, la division por cero no da error sino infinito, en los enteros si da error en tiempo de ejecucion.

            /*EJERCICIO 16*/

            // static void numeros()
            // {   
            //     string str = "0";
            //     int x = 0;

            //     while(str != "" && str != " ")
            //     {
            //         try
            //         {
            //             sumar(ref str, ref x);
            //         }
            //         catch(FormatException)
            //         {
            //             Console.WriteLine("El dato ingresado no es un numero valido");
            //         }
            //     }

            //     static void sumar(ref string str, ref int x)
            //     {
            //         Console.Write("Ingrese un numero para sumarse: ");
            //         str = Console.ReadLine();
            //         x += Int32.Parse(str);
            //         Console.WriteLine($"Hasta aquí el total es: {x}");
            //     }
            // }

            // numeros();

            /*EJERCICIO 17*/

            // static void expresion(string exp)
            // {  
            //     try
            //     {
            //         if(exp.Contains('+') || exp.Contains('-') || exp.Contains('*') || exp.Contains('/'))
            //         {
            //             string[] arr = exp.Split(new Char [] {'+', '-', '*', '/'});
            //             double a = Double.Parse(arr[0]);
            //             double b = Double.Parse(arr[1]);
            //             checkOperacion(exp, a, b);
            //         }
            //         else
            //         {
            //             throw new Exception("No hay operacion posible en la expresion.");
            //         }                   

            //     }
            //     catch(FormatException)
            //     {
            //         Console.WriteLine("El dato ingresado no es una expresion valida");
            //     }
            //     catch(Exception e)
            //     {
            //         Console.WriteLine(e.Message);
            //         return;
            //     }

            //     static void checkOperacion(string exp, double a, double b)
            //     {
            //         if(exp.Contains('+'))
            //         {
            //             Console.WriteLine("El resultado de la operacion es " + (a + b));
            //         }
            //         else if(exp.Contains('-'))
            //         {
            //             Console.WriteLine("El resultado de la operacion es " + (a - b));
            //         }
            //         else if(exp.Contains('*'))
            //         {
            //             Console.WriteLine("El resultado de la operacion es " + (a * b));
            //         }
            //         else if(exp.Contains('/'))
            //         {
            //             Console.WriteLine("El resultado de la operacion es " + (a / b));
            //         }
            //     }
            // }

            // string exp = "125/10";
            // expresion(exp);

            /*EJERCICIO 18*/

            // try
            // {
            //     Metodo1();
            // }
            // catch
            // {
            //     Console.WriteLine("Método 1 propagó una excepción no tratada");
            // }
            // try
            // {
            //     Metodo2();
            // }
            // catch
            // {
            //     Console.WriteLine("Método 2 propagó una excepción no tratada");
            // }
            // try
            // {
            //     Metodo3();
            // }
            // catch
            // {
            //     Console.WriteLine("Método 3 propagó una excepción");
            // }

            // static void Metodo1()
            // {
            //     object obj = "hola";

            //     try
            //     {
            //         int i = (int)obj;
            //     }
            //     finally
            //     {
            //         Console.WriteLine("Bloque finally en Método 1");
            //     }
            // }

            // static void Metodo2()
            // {
            //     object obj = "hola";
            //     try
            //     {
            //         int i = (int)obj;
            //     }
            //     catch(OverflowException)
            //     {
            //         Console.WriteLine("Overflow");
            //     }
            // }

            // static void Metodo3()
            // {
            //     object obj = "hola";
            //     try
            //     {
            //         int i = (int)obj;
            //     }
            //     catch(InvalidCastException)
            //     {
            //         Console.WriteLine("Excepción InvalidCast en Método 3");
            //         throw;
            //     }
            // }

            //Respuesta
            // Método 1 propagó una excepción no tratada.
            // Método 2 propagó una excepción no tratada.
            // Método 3 propagó una excepción.
            // Bloque finally en Método 1.
            // Excepción InvalidCast en Método 3.


            Console.ReadKey();


        }
    }
}
