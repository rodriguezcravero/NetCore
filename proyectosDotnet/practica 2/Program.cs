using System;
using System.Text;

// enum Meses
//             {
//                 Enero = 1,
//                 Febrero,
//                 Marzo,
//                 Abril,
//                 Mayo,
//                 Junio,
//                 Julio,
//                 Agosto,
//                 Septiembre,
//                 Octubre,
//                 Noviembre,
//                 Diciembre
//             }

namespace teo2
{
    class Program
    {

        static void Main(string[] args)
        {

            int[] vector = default;

            Console.WriteLine(vector == null);

            /*EJERCICIO 1*/
            /* Qué líneas del siguiente código provocan conversiones ​boxing ​ y ​unboxing.*/
            /*
            char​ ​c1​ = ​'A'​; //Asignación normal
            ​string​ ​st1​ = ​"A"​; //Asignación normal
            object​ ​o1​ = ​c1​; // Boxing: guardando un char en un object.
            object​ ​o2​ = ​st1​; // No hay boxing, porque ambas son de referencia.
            ​char​ ​c2​ = (​char​)​o1​;  // Unboxing: guardando en un char el cast del object con char.
            string​ ​st2​ = (​string​)​o2​; // No hay unboxing.
            */

            /*EJERCICIO 2*/
            /*static​ ​void​ ​Main​(​string​[] ​args​)         
            {             
            object o1 = "A";
            object o2 = o1;
            o2 = "Z";
            Console.WriteLine(o1 + " , " + o2);         
            }
            El tipo ​object es un tipo referencia, por lo tanto luego de la sentencia ​o2 = o1 ambas
            variables están apuntando a la misma dirección. ¿Cómo explica entonces que el resultado en la
            consola no sea “​Z Z​”? 
            
            Respuesta: debido a que en la 2º línea, se hace el unboxing del string, entonces se guarda el valor de o1 y no su referencia.
            */

            /*EJERCICIO 3*/
            /*
            Analizar la siguiente porción de código para calcular la sumatoria de 1 a 10. ¿Cuál es el error? 
            ¿Qué hace realmente?  ​                        
            
            int sum = 0;
            int i = 1;
            while (i <= 10);
            {
                sum += i++;
            }
            Console.WriteLine(sum);

            Respuesta: tiene un ';' después del while, por ende queda en un loop infinito no haciendo nada.
            */

            /*EJERCICIO 4*/
            /*
            ¿Cuál es la salida por consola si no se pasan argumentos por la línea de comandos?
            class​ ​Program {     
                ​public​ ​static​ ​void​ ​Main​(​string​[] ​args​)     
                {                
                    ​System​.​Console​.​WriteLine​(​args​ == ​null​); // False: es un array de Strings vacío
                    System​.​Console​.​WriteLine​(​args​.​Length​);  // 0
                } 
            */

            /*EJERCICIO 5*/
            /*¿Qué hace la instrucción
            
            int​[] ​vector​ = ​new​ ​int​[​0​]; 
            ¿asigna a vector el valor ​null​? 
            
            Respuesta: no, de hecho el siguiente comando arroja 'true';
            Console.WriteLine(vector != null);
            Lo que hay asignado es un Array de Int32 vacío.
            */

            /*EJERCICIO 6*/
            /*
            Determinar qué hace el siguiente programa y explicar qué sucede si no se pasan parámetros
            cuando se invoca desde la línea de comandos.
            Console​.​WriteLine​(​"¡Hola {0}!"​, ​args​[​0​]); // Exception, porque se está intentando acceder a una posiciòn del array que no existe.
            */

            /*EJERCICIO 7*/
            /*Analizar el siguiente código. 
            ¿Qué líneas producen error de compilación y por qué? 
             ​
            char​ ​c​; // Warning de variable nunca asignada.       ​
            char​? ​c2​; // Lo mismo.   
            ​string​ ​st​;  // Lo mismo.           
            ​c​ = ​""​; // Error: No se puede convertir implicitamente un string a un char;        
            ​c​ = ​''​; // Error: Literal de caracter vacío.     
            ​c​ = ​null​; // Error: no se puede asignar null a un tipo valor.
            ​c2​ = ​null​; // No hay problema.          
            ​c2​ = (​65​ ​as​ ​char​?); // 15 errores.          ​
            st​ = ​""​; // No hay problema, string vacío.          
            ​st​ = ​''​; // Error: Literal de caracter vacío.          ​
            st​ = ​null​; // No hay problema.            
            ​st​ = (​char​)​65​; // Error: No se puede convertir implicitamente un char a String.
            ​st​ = (​string​)​65​; // Error: No se puede convertir int a String.
            st​ = ​47.89​.​ToString​(); // No hay problema.  
            */

            /*EJERCICIO 8*/
            /*Los nombre son pasados en 'dotnet run X Y Z', en la terminal*/
            /*
            foreach(string nombre in args)
            {
                if(nombre == "Maria")
                {
                    Console.WriteLine(nombre + ", que tengas buenas tardes.");
                }
                else if (nombre == "Jose")
                {
                    Console.WriteLine("Buen día  " + nombre);
                }
                else
                {
                    Console.WriteLine("Bienvenido " + nombre);
                }
            }

            for(int i = 0; i < args.Length; i++)
            {
                if (i == 0)
                {
                    Console.WriteLine("Bienvenido " + args[0] + ", sos el/la primero/a en llegar");
                }
                else if(i  == 1)
                {
                    Console.WriteLine("El segundo/a que saludamos es a " + args[1]);
                }
                else
                {
                    Console.WriteLine(args[i] + " bienvenido/a");
                }
            }
            */

            /*EJERCICIO 9*/
            /*
            Investigar acerca de la clase ​StringBuilder del espacio de nombre​System​.​Text ¿En qué             
            circunstancias es preferible utilizar ​StringBuilder en lugar de utilizar​ string​? Implementar           
            un caso de ejemplo en el que el rendimiento sea claramente superior utilizando             
            StringBuilder​ y otro en el que no.

            Respuesta: El StringBuilder resulta más práctico para modificar el contenido de un String, pero como se ve en el ejercicio 10,
            para trabajar un for de 300 cambios, resulta más rápido hacerlo con el string normal, ya que es por valor.
            */
            


            /*EJERCICIO 10*/
            /*
            Investigar sobre el tipo ​DateTime y usarlo para medir el tiempo 
            de ejecución de los algoritmos implementados en el ejercicio anterior.

            DateTime antesDelStrB = DateTime.Now;  
            Console.WriteLine("Antes del StrB - " + antesDelStrB.ToString("HH, mm, ss, fff"));

            StringBuilder​ strB = new StringBuilder("");

            for (int i = 0; i < 300; i++)
            {
                strB.Append("A, ");
            }

            DateTime despuesDelStrB = DateTime.Now;  
            Console.WriteLine("Despues del StrB - " + despuesDelStrB.ToString("HH, mm, ss, fff"));

            Console.WriteLine("**");            

            DateTime antesDelStringNormal = DateTime.Now;  
            Console.WriteLine("Antes del String normal - " + antesDelStringNormal.ToString("HH, mm, ss, fff"));

            string str = "";

            for (int i = 0; i < 300; i++)
            {
                str += "A, ";
            }

            DateTime despuesDelStringNormal = DateTime.Now;  
            Console.WriteLine("Despues del string normal - " + despuesDelStringNormal.ToString("HH, mm, ss, fff"));

            */

            /*EJERCICIO 11*/
            /*
            ¿Para qué sirve el método ​Split de la clase​ string​? Usarlo para escribir en la consola todas                 
            las palabras (una por línea) de una frase ingresada por el usuario.

            Console.Write("Ingrese una frase: ");
            string frase = Console.ReadLine();
            string[] palabras = frase.Split(" ");
            foreach (string palabra in palabras)
            {
                Console.WriteLine(palabra);
            }

            */

            /*EJERCICIO 12*/
            /*
            Comprobar el funcionamiento del siguiente programa y dibujar el estado de la pila y la memoria                
            heap ​cuando la ejecución alcanza los puntos indicados (comentarios en el código) 

            object[] v = new object[10];
            v[0] = new StringBuilder("Net");

            for (int i = 1; i < 10; i++)
            {
                v[i] = v[i - 1];
            }

            (v[5] as StringBuilder).Insert(0, "Framework .");
            foreach (StringBuilder s in v)
            Console.WriteLine(s);

            // dibuje el estado de la pila y la mem. heap
            // en este punto de la ejecución

            Console.WriteLine("*");

            v[5] = new StringBuilder("CSharp");
            foreach (StringBuilder s in v)
            Console.WriteLine(s);

            //dibuje el estado de la pila y la mem. heap
            //en este punto de la ejecución
            /*
            

            /*EJERCICIO 13*/
            /*
            Definir el tipo de datos enumerativo llamado ​Meses​ y utilizarlo para:  
            a) Imprimir en la consola el nombre de cada uno de los mesesenordeninverso(diciembre,                 
            noviembre, octubre …, enero) 
            c) Solicitar al usuario que ingrese un texto y responder si el texto tipeado corresponde al                
            nombre de un mes  Nota​: en todos los casos utilice un ​for​ iterando sobre una variable de tipo ​Meses 
            */

            // for (Meses mes = Meses.Diciembre; mes >= Meses.Enero; mes--)
            // {
            //     Console.WriteLine(mes);
            // }

            // Console.WriteLine("*******");

            // Console.Write("Por favor, ingrese un mes: ");
            // string str = Console.ReadLine();
            // bool flag = false;
            
            // for (Meses mes = Meses.Diciembre; mes >= Meses.Enero; mes--)
            // {
            //     if(str == mes.ToString())
            //     {
            //         flag = true;
            //     }
            // }

            // if(flag){Console.WriteLine("El texto ingresado sí corresponde a un mes!");}
            // else {Console.WriteLine("No hay ningún mes llamado así.");}

            /*EJERCICIO 14*/
            /*
            Implementar un programa que muestre todos los números primos entre 1 y un número natural               
            dado (pasado al programa como argumento por la línea de comandos). Definir el método              
            static bool esPrimo(int n) que devuelve​true sólo si ​n es primo. Esta función debe               
            comprobar si ​n es divisible por algún número entero entre 2 y la raíz cuadrada de ​n ​ . 
            (Nota: Math.sqrt(d)​ devuelve la raíz cuadrada de​ d​) 
 
            String primos = "1";

            Console.Write("Ingrese hasta qué numero quiere recibir un listado de naturales: ");
            int numFinal = int.Parse(Console.ReadLine());

            static bool esPrimo(int n)
            {
                for (int i = 2; i <= Math.Sqrt(n); i++)
                {
                    if(n % i == 0)
                    {
                        return false;
                    }
                }
                return true;
            }

            for (int i = 2; i < numFinal; i++)
            {
                if(esPrimo(i))
                {
                    primos += ", " + i.ToString();
                }
            }

            Console.WriteLine(primos);
            */

            /*EJERCICIO 15*/
            /*
            static int fib(int n)
            {
                if(n < 2)
                {
                    return 1;
                }
                else
                {
                    return fib(n - 1) + fib(n - 2);
                } 
            }
            Console.WriteLine(fib(7)); //Output 21.
            */

            /*EJERCICIO 16*/
            /*
            Escribir una función (método ​static int fac(int n)​) que calcule el factorial de un              
            número ​n ​ pasado al programa como parámetro por la línea de comando 
            a) Definiendo una función no recursiva 
            b) Definiendo una función recursiva 
            c) idem a b) pero con ​expression-bodied methods (Tip: utilizar el operador condicional ternario) 

            static int facNoRec(int n)
            {
                int res = 1;

                for (int i = 1; i <= n; i++)
                {
                    res *= i;
                }

                return res;
            }

            int resultadoRecursivo = 1;

            static int facRec(int n, int resultadoRecursivo)
            {
                if(n == 1)
                {
                    return resultadoRecursivo;
                }
                else 
                {
                    resultadoRecursivo *= n--;
                    return facRec(n, resultadoRecursivo);
                }
            }

            int resultadoEBM = 1;

            static int facEBM(int n, int resultadoEBM) => (n == 1) ? 1 : facEBM(n-1, resultadoEBM)*n;

            Console.WriteLine(facNoRec(3));
            Console.WriteLine();
            Console.WriteLine(facRec(5, resultadoRecursivo));
            Console.WriteLine();
            Console.WriteLine(facEBM(4, resultadoEBM));

            */
            
            /*EJERCICIO 17*/
            /*
            17. Ídem. al ejercicio 16.a) y 16.b) pero devolviendo el resultado en un parámetro de salida
            static void fac(int n, out int f)

            static void facOut(int n, out int f)
            {
                f = 1;
                for (int i = 1; i <= n; i++)
                {
                    f *= i;
                }
                Console.WriteLine(f);
            }

            facOut(5, out int f);
            */
            
            /*EJERCICIO 18*/
            /*
            18. Codificar el método swap que recibe 2 parámetros enteros e intercambia sus valores. El cambio
            debe apreciarse en el método invocador.

            int a = 1;
            int b = 99;

            static void swap(ref int a, ref int b)
            {
                int aux = a;
                a = b;
                b = aux;
            }

            Console.WriteLine("A: " + a + " - B: " + b);
            swap(ref a, ref b);
            Console.WriteLine("A: " + a + " - B: " + b);

            */

            
            /*EJERCICIO 19*/
            /*
            Codificar el método imprimir para que el siguiente código produzca 
            la salida por consola que se observa. 
            imprimir​(​1​, ​"casa"​, ​'A'​, ​3.4​, ​DayOfWeek​.​Saturday​);     ​
            imprimir​(​1​, ​2​, ​"tres"​);     
            imprimir​();     ​
            imprimir​(​"-------------"​); 

            static void imprimir(params object[] str)
            {
                foreach(object o in str)
                {
                    Console.Write(o.ToString() + " ");
                }
                Console.WriteLine();
            }

            imprimir(1, "casa", 'A', 3.4, DayOfWeek.Saturday);
            imprimir(1, 2, "tres");
            imprimir();
            imprimir("-------------");
            */




            Console.ReadKey();

        }
    }
}
