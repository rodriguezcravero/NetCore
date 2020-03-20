using System;

namespace practica1
{
    class Program
    {
        static void Main(string[] args)
        {
            //EJERCICIO 1
            /*
            Console.Write("Hello ");
            Console.ReadKey();
            Console.WriteLine("World!");

            */

            //EJERCICIO 2

            //string str = "Hola \n Mundo. \t ¿Como \" estas? \\";
            //Console.WriteLine(str);

            //EJERCICIO 3
            /*
            string st = "c:\\windows\\system";
            Console.WriteLine(st);
            */

            //EJERCICIO 4
            
            Console.Write("Hola, por favor ingrese su nombre: ");
            string nombre = Console.ReadLine();

            if(nombre != "")
            {
                Console.WriteLine("Bienvenido " + nombre);
            }
            else
            {
                Console.WriteLine("Hola mundo!");
            }
            

            //EJERCICIO 5

            /* Idem al ejercicio anterior salvo que se imprimirá un mensaje de saludo diferente según sea el nombre ingresado por el usuario. 
             * Así para “Juan”debe imprimir “¡Hola amigo!”, 
             * para “María” debe imprimir “Buen día señora”, 
             * para “Alberto” debe imprimir “Hola Alberto”.
             * En otro caso, debe imprimir “Buen día ”seguido del nombre ingresado o 
             * “¡Buen día mundo!” si se ha ingresado una línea vacía*/

            //5-a
            /*
            Console.Write("Hola, por favor ingrese su nombre: ");
            string nombre = Console.ReadLine();

            if (nombre == "")
            {
                Console.WriteLine("¡Buen dia mundo!");
            }
            else if (nombre == "Juan")
            {
                Console.WriteLine("¡Hola amigo!");
            }
            else if (nombre == "Maria")
            {
                Console.WriteLine("Buen dia señora");
            }
            else if (nombre == "Alberto")
            {
                Console.WriteLine("Hola Alberto!");
            }
            else
            {
                Console.WriteLine("Buen dia " + nombre);
            }
            */

            //5-b
            /*
            Console.Write("Hola, por favor ingrese su nombre: ");
            string nombre = Console.ReadLine();

            switch (nombre)
            {
                case "Juan":
                    {
                        Console.WriteLine("¡Hola amigo!");
                        break;
                    }
                case "Maria":
                    {
                        Console.WriteLine("Buen dia señora");
                        break;
                    }
                case "Alberto":
                    {
                        Console.WriteLine("Hola Alberto!");
                        break;
                    }
                case "":
                    {
                        Console.WriteLine("¡Buen dia mundo!");
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Buen dia " + nombre);
                        break;
                    }
            }
            */

            //EJERCICIO 6

            /*
            Console.Write("Ingrese una cadena de texto y se informara la cantidad de caracteres: ");
            string str = Console.ReadLine();
            while(str != "")
            {
                Console.WriteLine("Cantidad de caracteres ingresados: " + str.Length);
                Console.WriteLine();
                Console.Write("Ingrese otra cadena de texto y se informara la cantidad de caracteres o enter para terminar: ");
                str = Console.ReadLine();
            }
            */

            //EJERCICIO 7

            //Qué hace la instrucción?
            //Respuesta: "100" es tomado como una cadena de string literal, por ende devuelve el 'length' de la cadena, es decir, el numero 3;

            /*
            Console.WriteLine("100".Length);
            */

            //EJERCICIO 8

            //Sea​ st una variable de tipo string correctamente declarada. ¿Es válida la siguiente instrucción: 
            //Respuesta: Si. Si solamente se declara y no se asigna valor a 'st', lo que hará el método WriteLine es mantenerse a la espera de
            //la ejecucion del segundo método que es ReadLine para terminar la ejecucion. Se leerá el string ingresado, y luego se imprimirá.

            /*
            string st;

            Console.WriteLine(st = Console.ReadLine());
            ^*/



            //EJERCICIO 9

            //????????????????????? no se cómo se resuelve



            //EJERCICIO 10

            /*
            for (int i = 1; i <= 1000; i++)
            {
                if((i % 17) == 0 || (i % 29) == 0)
                {
                    Console.WriteLine("Nº " + i);
                }
            }
            */


            //EJERCICIO 11

            //¿Qué se puede concluir respecto del operador de división “​/​” ?
            //Respuesta: si son dos enteros, devuelve un entero. Si al menos uno de ellos no es entero, devuelve con coma.
            //¿Cómo funciona el operador ​+​ entre un ​string​ y un dato numérico?
            //Respuesta: concatena ambos.
            /*
            Console.WriteLine("10 / 3: " + 10 / 3);
            Console.WriteLine("10.0 / 3: " + 10.0 / 3);
            Console.WriteLine("10.0 / 3.0: " + 10.0 / 3.0);

            int a = 10, b = 3;
            Console.WriteLine("Si a y b son variables enteras, si a = 10 y b = 3, ");
            Console.WriteLine("entonces a / b = " + a / b);

            double c = 3;
            Console.WriteLine("Si c es una variable double, c = 3, ");
            Console.WriteLine("entonces a / c = " + a / c);
            */

            //EJERCICIO 12

            /*
            Console.WriteLine("Ingrese un entero para recibir sus divisores");
            string st = Console.ReadLine();
            int num = int.Parse(st);

            for(int i = num; i > 0; i--) 
            { 
                if(num % i == 0)
                {
                    Console.WriteLine("El numero " + i + " es divisor de " + num);
                }
            }
            */

            //EJERCICIO 13
            /*
            Escribir un programa que calcule la suma de dos números reales introducidos por teclado y 
            muestre el resultado en la consola (utilizar ​Convert.ToDouble(st) ​o ​double.Parse(st)
            para obtener el valor real a partir del ​string​ ​st​.
            */
            /*
            Console.Write("Ingrese un primer numero real: ");
            double real1 = double.Parse(Console.ReadLine());
            Console.Write("Ingrese un segundo numero real: ");
            double real2 = double.Parse(Console.ReadLine());

            Console.WriteLine("El resultado de la suma de ambos es " + (real1 + real2));
            */

            //EJERCICIO 14

            //----------------

            //EJERCICIO 15
            /*
            Escribir un programa que solicite un año por pantalla y diga si es bisiesto.Un año es bisiesto
            bajo si es divisible por 4 pero no por 100.Si es divisible por 100, para ser bisiesto debe ser divisible por 400.
            */
            /*
            Console.Write("Ingrese un año para saber si es bisiesto: ");
            int year = int.Parse(Console.ReadLine());

            if((year % 4 == 0 && year % 100 != 0) || (year % 100 == 0 && year % 400 == 0))
            {
                Console.WriteLine("El año ingresado es bisiesto");
            }
            else
            {
                Console.WriteLine("El año no es bisiesto");
            }
            */

            //EJERCICIO 16

            //------------------- no entendi



            //EJERCICIO 17

            /*Utilizar el operador ternario condicional para establecer elcontenido 
             de una variable entera con el menor valor de otras dos variables enteras. */
            /*
            Console.WriteLine("Ingrese dos numeros enteros y se retornará el menor de ellos.");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            int menor = (a < b) ? a : b;

            Console.WriteLine("La cifra ingresada menor en " + menor);
            */

            //EJERCICIO 18
            /*
            ¿Cuál es la salida por consola del siguiente código?

            for(int i = 0; i <= 4; i++)
            {
                string st = i < 3 ? i == 2 ? "dos" : i == 1 ? "uno" : " < 1" : i < 4 ? "tres" : " > 3";
                Console.WriteLine(st);
            }
            */

            //EJERCICIO 19
            /*

            
  
            13.   ​char​ ​c​ = ​'A'​, ​st​ = ​"Hola"​
            */

            //int a, b, c; //Variables declaradas correctamente pero sin utilizar ni asignar.
            //int a; int b; int c, d; //Variables declaradas correctamente pero sin utilizar ni asignar.
            //int a = 1; int b = 2; int c = 3; //Variables declaradas y asignadas correctamente pero sin utilizar
            //int b; int c; int a = b = c = 1; //Variable asignada sin utilizar, a y b asignacion innecesaria, todas valen 1.
            //int c; int a, b = c = 1;//Variable c asignada pero valor sin usar, a declarada pero sin usar
            //int c; int a = 2, b = c = 1;//Compilacion correcta, todas las variables asignadas.
            //int a = 2, b, c, d = 2 * a; //Variables b y c sin asignar.
            //int a = 2, int b = 3, int c = 4; //Error, hay que separar con ';'.
            //int a = 2; b = 3; char = 4; //Error, falta el identificador int en b y c.
            //int a; int c = a; //Error: se intenta utilizar a 'a' sin haberle dado valor.
            //char c = 'A', string st = "Hola"; //Hay que usar ';' en vez de la coma.
            //char c = 'A'; string st = "Hola"; //Declaradas correctamente.
            //char c = 'A', st = "Hola"; //Error, implicitamente se está tratando al string como char con la coma.
            //Console.WriteLine(a); Console.WriteLine(b); Console.WriteLine(c); //Console.WriteLine(d);


            //EJERCICIO 20 
            //¿Cuál es el problema del código siguiente y cómo se soluciona? 
            //No se puede declarar una variable del mismo nombre dentro de un bloque donde previamente en el scope anterior se
            //declaró una del mismo nombre (en este caso, i). 

            /*
            int​ ​i​ = ​0​;
            
            for​(​int​ ​i​ = ​1​; ​i​ <= ​10​;)
            {                 ​
                Console​.​WriteLine​(​i​++); 
            }
            */

            //int i = 0;
            /*
            for(int i = 1; i <= 10;)
            {
                Console.WriteLine(i++);
            }
            */

            //EJERCICIO 21
            //Analizar el siguiente código. ¿Cuál es la salida por consola? 
            //Respuesta: cero cero 1
            /*

            int i = 1;
            if(--i == 0)
            {
                Console.WriteLine("cero");
            }
            if(i++ == 0)
            {
                Console.WriteLine("cero");
            }
            Console.WriteLine(i); ;
            */
        }
    }
}
