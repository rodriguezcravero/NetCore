using System;
using System.IO;
using System.Collections;

namespace typ4
{

    class Program
    {

        /*EJERCICIO 9*/

    //     class Program
    // {
    //     static Auto a; //En este primer caso, no se instancio el objeto, a es nullo
    //     static void Main()
    //     {
    //         a.Velocidad = 10;
    //     }

    //     static void Main()
    //     {
    //         Auto a; // a no está asignada a nada
    //         a.Velocidad = 10;
    //     }
    // }

    // class Auto
    // {
    //     public double Velocidad;
    // }


        static void Main(string[] args)
        {
            /*EJERCICIO 1*/

            // Persona1[] listado = new Persona1[6];

            // Console.SetIn(new StreamReader("personas.txt"));

            // for (int i = 0; i < listado.Length; i++)
            // {
            //     Persona1 p = new Persona1();
            //     string[] datos = Console.ReadLine().Split(' ');
            //     p.Nombre = datos[0];
            //     p.Edad = Int32.Parse(datos[1]);
            //     p.DNI = Int32.Parse(datos[2]);

            //     listado[i] = p;
            // }

            // Console.WriteLine("Nro)         Nombre          Edad            DNI");
            // int j = 1;

            // foreach(Persona1 p in listado)
            // {
            //     Console.WriteLine($"{j++})          {p.Nombre}          {p.Edad}            {p.DNI}");
            // }


            /*EJERCICIO 2*/

            // Persona2[] listado = new Persona2[5];

            // Console.SetIn(new StreamReader("personas.txt"));

            // for (int i = 0; i < listado.Length; i++)
            // {
            //     string[] datos = Console.ReadLine().Split(' ');
            //     Persona2 p = new Persona2(datos[0], Int32.Parse(datos[1]), Int32.Parse(datos[2]));

            //     listado[i] = p;
            // }

            // Console.WriteLine("Nro)     Nombre        Edad     DNI");

            // for (int i = 0; i < listado.Length; i++)
            // {
            //     listado[i].Imprimir(i+1);
            // }


            /*EJERCICIO 3*/

            // Persona2[] listado = new Persona2[5];

            // Console.SetIn(new StreamReader("personas.txt"));

            // for (int i = 0; i < listado.Length; i++)
            // {
            //     string[] datos = Console.ReadLine().Split(' ');
            //     Persona2 p = new Persona2(datos[0], Int32.Parse(datos[1]), Int32.Parse(datos[2]));

            //     listado[i] = p;
            // }

            // Console.WriteLine("Nro)     Nombre        Edad     DNI");
            
            // Persona2 masJoven = listado[0];

            // for (int i = 0; i < listado.Length; i++)
            // {
            //     listado[i].Imprimir(i+1);
                
            //         if(!listado[i].EsMayorQue(masJoven))
            //         {
            //             masJoven = listado[i];
            //         }
            // }

            // Console.WriteLine();
            // Console.WriteLine($"El más joven es {masJoven.GetName()}");

            /*EJERCICIO 4*/

            // Hora h = new Hora(23, 30, 15);
            // h.Imprimir();
            
            // Console.WriteLine();

            /*EJERCICIO 5*/

            // new Hora(23, 30, 15).Imprimir();
            // new Hora(14.43).Imprimir();
            // new Hora(14.45).Imprimir();
            // new Hora(14.45114).Imprimir();

            /*EJERCICIO 6*/

            // Ecuacion2 e = new Ecuacion2(1, -2, 1);

            // Console.WriteLine("Discriminante: " + e.GetDiscriminante());

            // e.ImprimirRaices();


            /*EJERCICIO 7*/

            // Nodo n = new Nodo(7);
            // n.Insertar(8);
            // n.Insertar(10);
            // n.Insertar(3);
            // n.Insertar(1);
            // n.Insertar(5);
            // n.Insertar(14);
            // foreach (int i in n.GetInOrder())
            // {
            //     Console.Write(i + " ");
            // }
            // Console.WriteLine();
            // Console.WriteLine(n.GetAltura());
            // Console.WriteLine(n.GetCantNodos());
            // Console.WriteLine(n.GetValorMaximo());
            // Console.WriteLine(n.GetValorMinimo());

            /*EJERCICIO 8*/

            // Matriz A = new Matriz(2, 3);
            // for(int i = 0; i < 6; i++) A.SetElemento(i/3, i%3, (i+1)/3.0);
            // Console.WriteLine("Impresion de la matriz A");
            // A.Imprimir("0,000");

            // double[,] aux = new double[,] {{1, 2, 3}, {4, 5, 6}, {7, 8, 9}};
            // Matriz B = new Matriz(aux);
            // Console.WriteLine("\nImpresión de la matriz B");
            // B.Imprimir();

            // Console.WriteLine("\nAcceso al elemento B[1,2]= {0}", B.GetElemento(1,2));
            
            // Console.Write("\nfila 1 de A: ");
            // foreach (double d in A.GetFila(1)) Console.Write("{0:0.0} ", d);

            // Console.Write("\n\nColumna 0 de B: ");
            // foreach (double d in B.GetColumna(0)) Console.Write("{0} ", d);

            // Console.Write("\n\nDiagonal principal de B: ");
            // foreach (double d in B.GetDiagonalPrincipal()) Console.Write("{0} ", d);

            // Console.Write("\n\nDiagonal secundaria de B: ");
            // foreach (double d in B.GetDiagonalSecundaria()) Console.Write("{0} ", d);

            // A.multiplicarPor(B);
            // Console.WriteLine("\n\nA multiplicada por B");
            // A.Imprimir();

            /*EJERCICIO 9*/

            //Hecho arriba de todo


            /*EJERCICIO 10*/

            //Entre el primer y segundo metodo no habría problema, entre el 2º y 3º si.


            /*EJERCICIO 11*/

            // object o = 5; 
            // Procesar(o, o); // Imprime: dynamic d1: 5, dynamic d2: 5
            // Procesar((dynamic)o, o); // Imprime: entero: 5, objeto: 5
            // Procesar((dynamic)o, (dynamic)o); // Imprime: entero: 5, objeto: 5
            // Procesar(o, (dynamic)o); // Imprime: dynamic d1: 5, dynamic d2: 5
            // Procesar(5, 5); // Imprime: entero: 5, objeto: 5


            /*EJERCICIO 12*/

            // Cuenta cuenta = new Cuenta();
            // cuenta.Imprimir();
            // cuenta = new Cuenta(30222111);
            // cuenta.Imprimir();
            // cuenta = new Cuenta("Jose Perez");
            // cuenta.Imprimir();
            // cuenta = new Cuenta("Maria Diaz", 20287544);
            // cuenta.Imprimir();
            // cuenta.Depositar(200);
            // cuenta.Imprimir();
            // cuenta.Extraer(150);
            // cuenta.Imprimir();
            // cuenta.Extraer(1500);


            /*EJERCICIO 13*/

            // string st;
            // string st1 = null;
            // string st2 = "ejemplo 1";
            // string st3 = "";
            // string st4 = null;

            // if(st1 == null)
            // {
            //     if(st2 == null)
            //     {
            //         st = st3;
            //     }
            //     else
            //     {
            //         st = st2;
            //     }
            // }
            // else
            // {
            //     st = st1;
            // }
            // if(st4 == null)
            // {
            //     st4 = "valor por defecto";
            // }
            
            // st = st1 ?? st2 ?? st3;
            // st4 ??= "valor por defecto";

            // Console.WriteLine("String " + st);
            // Console.WriteLine("String 1" + st1);
            // Console.WriteLine("String 2" + st2);
            // Console.WriteLine("String 3" + st3);
            // Console.WriteLine("String 4" + st4);


            Console.ReadKey();

        }
    }

    // class Persona1
    // {
    //     public string Nombre;
    //     public int Edad;
    //     public int DNI;

    // }

    class Persona2
    {
        private string _nombre;
        private int _edad;
        private int _dni;

        public Persona2(string Nombre, int Edad, int DNI)
        {
            _nombre = Nombre;
            _edad = Edad;
            _dni = DNI;
        }

        public void Imprimir(int contador)
        {
            Console.WriteLine($"{contador})   {_nombre, 10}          {_edad}   {_dni}");
        }

        public bool EsMayorQue(Persona2 p)
        {
            return(this._edad > p._edad);
        }

        public string GetName()
        {
            return _nombre;
        }
    }


    /*#############################################################*/




    class Hora
    {
        int _horas;
        int _minutos;
        int _segundos;
        double _milisegundos;

        public Hora(int Horas, int Minutos, int Segundos)
        {
            this._horas = Horas;
            this._minutos = Minutos;
            this._segundos = Segundos;
        }

        public Hora(double tiempo)
        {
            this._horas = (int)tiempo;

            double min = tiempo - (int)tiempo;
            min *= 60;
            int m = (int)min;

            if(m == 60)
            {
                this._horas++;
                this._minutos = 0;
            }
            else
            {
                this._minutos = m;
            }

            double sec = min - (int)(min);
            sec *= 60;

            if(sec > 59.999)
            {
                this._minutos++;
                this._milisegundos = 0;
            }
            else
            {
                this._milisegundos = sec;
            }

            this._segundos = -1;
        }

        public void Imprimir()
        {
            if(this._segundos == -1) 
            {
                Console.WriteLine($"{_horas} horas, {_minutos} minutos y {_milisegundos:0.000} segundos");
             }
             else
             {
                 Console.WriteLine($"{_horas} horas, {_minutos} minutos y {_segundos} segundos");
             }
        }
    }

    

    /*#############################################################*/


    

    class Ecuacion2
    {
        double a;
        double b;
        double c;

        public Ecuacion2(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public double GetDiscriminante()
        {
            return(Math.Pow(b, 2) - (4*a*c));
        }

        public int GetCantidadDeRaices()
        {
            if(this.GetDiscriminante() < 0)
            {
                //Console.WriteLine("No tiene soluciones en la dimensión de los Reales");
                return 0;
            }
            else if(this.GetDiscriminante() > 0)
            {
                //Console.WriteLine("La ecuación tiene dos soluciones.");
                return 2;
            }
            else
            {
                //Console.WriteLine("La ecuación presenta una única solución.");
                return 1;
            }
        }

        public void ImprimirRaices()
        {
            if(this.a == 0)
            {
                Console.WriteLine("El término 'a' debe ser distinto de 0");
                return;
            }
            else
            {
                if(this.GetCantidadDeRaices() == 0)
                {
                    Console.WriteLine("No tiene soluciones en la dimensión de los Reales");
                }
                else
                {
                    double discriminante = this.GetDiscriminante();

                    double x1 = (-b + Math.Sqrt(discriminante))/(2*a);
                    double x2 = (-b - Math.Sqrt(discriminante))/(2*a);

                    if(x1 == x2)
                    {
                        Console.WriteLine($"La unica solución: {x1}");
                    }
                    else
                    {
                        Console.WriteLine($"Solución 1: {x1}");
                        Console.WriteLine($"Solución 2: {x2}");
                    }
                }
            }
        }
    }

    

    /*#############################################################*/


    

    class Cuenta
    {
        private double _monto;
        private int _titularDNI;
        private string _titularNombre;

        public Cuenta()
        {
            this._monto = 0;
            this._titularDNI = 0;
            this._titularNombre = "";
        }

        public Cuenta(string titular) : this()
        {
            this._titularNombre = titular;
        }

        public Cuenta(int DNI) : this()
        {
            this._titularDNI = DNI;
        }

        public Cuenta(string titular, int DNI) : this()
        {
            this._titularNombre = titular;
            this._titularDNI = DNI;
        }

        public void Depositar(int monto)
        {
            this._monto += monto;
        }

        public void Extraer(int monto)
        {
            if(this._monto - monto >= 0)
            {
                this._monto -= monto;
            }
            else
            {
                Console.WriteLine("Operación cancelada, monto insuficiente");
            }
        }

        public void Imprimir()
        { 
            string res = "";

            if(this._titularNombre == "")
            {
                res += "Nombre: No especificado";
            }
            else
            {
                res += "Nombre: " + this._titularNombre;
            }

            if(this._titularDNI == 0)
            {
                res += ", DNI: No especificado";
            }
            else
            {
                res += ", DNI: " + this._titularDNI;
            }

            res += ", Monto: " + this._monto;

            Console.WriteLine(res);
            
        }

    }


    // class A
    // {
    //     public void Metodo(short n)
    //     {
    //         Console.Write("short {0} - ", n);
    //     }

    //     public void Metodo(int n)
    //     {
    //         Console.Write("int {0} - ", n);
    //     }

    //     public int Metodo(int n)
    //     {
    //         return n + 10;
    //     }

    // }

    

    /*#############################################################*/


    


    class Matriz
    {
        double[,] matriz;
        int cantFilas;
        int cantColumnas;

        public Matriz(int filas, int columnas)
        {
            this.matriz = new double[filas, columnas];
            this.cantFilas = filas;
            this.cantColumnas = columnas;
        }

        public Matriz(double[,] matriz)
        {
            this.matriz = matriz;
            this.cantFilas = matriz.GetLength(0);
            this.cantColumnas = matriz.GetLength(0);
        }

        public int GetCantFilas()
        {
            return cantFilas;
        }

        public int GetCantColumnas()
        {
            return cantColumnas;
        }

        public void SetElemento(int fila, int columna, double elemento)
        {
            this.matriz[fila, columna] = elemento;
        }

        public double GetElemento(int fila, int columna)
        {
            return this.matriz[fila, columna];
        }

        public void Imprimir()
        {
            int filas = this.matriz.GetLength(0);
            int columnas = this.matriz.GetLength(1);

            for(int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    Console.Write($"{matriz[i,j]} ");
                }
                Console.WriteLine();
            }
        }

        public void Imprimir(string formatString)
        {
            int filas = this.matriz.GetLength(0);
            int columnas = this.matriz.GetLength(1);


            for(int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    //string res = String.Format(formatString, this.matriz[i,j]);
                    Console.Write($"{this.matriz[i,j]:0.000} ");
                }
                Console.WriteLine();
            }
        }

        public double[] GetFila(int fila)
        {
            int filas = this.matriz.GetLength(0);
            int columnas = this.matriz.GetLength(1);

            double[] arr = new double[columnas];

            for(int i = fila; i < fila+1; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    arr[j] = this.matriz[fila, j];
                }
            }

            return arr;

        }

        public double[] GetColumna(int columna)
        {
            int filas = this.matriz.GetLength(0);
            int columnas = this.matriz.GetLength(1);

            double[] arr = new double[filas];

            for(int i = columna; i < columna+1; i++)
            {
                for (int j = 0; j < filas; j++)
                {
                    arr[j] = this.matriz[j, columna];
                }
            }

            return arr;
        }

        public double[] GetDiagonalPrincipal()
        {
            double[] vacio = null;

            try
            {
                return funcion(this.matriz);
            }
            catch(ArgumentException e)
            {
                Console.WriteLine(e.Message);
                return vacio;
            }

            static double[] funcion(double[,] matriz)
            {
                int filas = matriz.GetLength(0);
                int columnas = matriz.GetLength(1);

                if(filas != columnas)
                {
                    throw new ArgumentException("\n La matriz no es cuadrada \n");
                }

                double[] diagonalPrincipal = new double[filas];

                for (int i = 0; i < filas; i++)
                {
                    diagonalPrincipal[i] = matriz[i, i];
                }

                return diagonalPrincipal;
            }
        }

        public double[] GetDiagonalSecundaria()
        {
            double [] vacio = null;
            try
            {
                return funcion2(this.matriz);
            }
            catch(ArgumentException e)
            {
                Console.WriteLine(e.Message);
                return vacio;
            }

            static double[] funcion2(double[,] matriz)
            {
                int filas = matriz.GetLength(0);
                int columnas = matriz.GetLength(1);

                if(filas != columnas)
                {
                    throw new ArgumentException("\n La matriz no es cuadrada \n");
                }

                double[] diagonalSecundaria = new double[columnas];
                int pos = 0;

                for (int i = columnas-1; i >= 0; i--)
                {
                    diagonalSecundaria[pos] = matriz[pos, i];
                    pos++;
                }

                return diagonalSecundaria;
            }
        }

        public double[][] GetArregloDeArreglo()
        {
            int filas = this.matriz.GetLength(0);
            int columnas = this.matriz.GetLength(1);

            double[][] arr = new double[filas][];

            for (int i = 0; i < filas; i++)
            {
                arr[i] = new double[columnas];

                for (int j = 0; j < columnas; j++)
                {
                    arr[i][j] = this.matriz[i, j];
                }
            }

            return arr;
        }

        public void sumarle(Matriz m)
        {
            int filasA = this.matriz.GetLength(0);
            int columnasA = this.matriz.GetLength(1);
            int filasB = m.GetCantFilas();
            int columnasB = m.GetCantColumnas();


            if( (filasA != filasB) && (columnasA != columnasB))
            {
               Console.WriteLine("Matrices incompatibles de sumar.");
            }
            else
            {
                for (int i = 0; i < filasA; i++)
                {
                    for (int j = 0; j < columnasA; j++)
                    {
                        this.matriz[i, j] = this.matriz[i, j] + m.GetElemento(i,j);
                    }
                }
            }
        }

        public void restarle(Matriz m)
        {
            int filasA = this.matriz.GetLength(0);
            int columnasA = this.matriz.GetLength(1);
            int filasB = m.GetCantFilas();
            int columnasB = m.GetCantColumnas();


            if( (filasA != filasB) && (columnasA != columnasB))
            {
               Console.WriteLine("Matrices incompatibles de sumar.");
            }
            else
            {
                for (int i = 0; i < filasA; i++)
                {
                    for (int j = 0; j < columnasA; j++)
                    {
                        this.matriz[i, j] = this.matriz[i, j] - m.GetElemento(i,j);
                    }
                }
            }
        }

        public void multiplicarPor(Matriz m)
        {
            int filasA = this.matriz.GetLength(0);
            int columnasA = this.matriz.GetLength(1);
            int filasB = m.GetCantFilas();
            int columnasB = m.GetCantColumnas();

            if(columnasA != filasB)
            {
                Console.WriteLine("La matrices no son compatibles para multiplicar.");
            }

            double[,] matrizRespuesta = new double[filasA, columnasB];

            for (int i = 0; i < filasA; i++)
            {
                for (int j = 0; j < columnasB; j++)
                {
                    double temp = 0;
                    for (int k = 0; k < columnasA; k++)
                    {
                        temp += this.matriz[i, k] * m.GetElemento(k, j);
                    }
                    matrizRespuesta[i, j] = temp;
                }
            }
            this.matriz = matrizRespuesta;
        }


    }



    /*#############################################################*/


    

    class Nodo
    {
        int num;
        Nodo izq;
        Nodo der;

        public Nodo(int numero)
        {
            num = numero;
            izq = null;
            der = null;
        }

        public void Insertar(int n)
        {
            if(n > this.num)
            {
                if(this.der != null)
                {
                    this.der.Insertar(n);
                }
                else
                {
                    this.der = new Nodo(n);
                }
            }
            else if (n < this.num)
            {
                if(this.izq != null)
                {
                    this.izq.Insertar(n);
                }
                else
                {
                    this.izq = new Nodo(n);
                }
            }
        }

        public int GetNum()
        {
            return this.num;
        }

        public int GetValorMinimo()
        {
            if(this.izq == null)
            {
                return this.num;
            }
            else
            {
                return(izq.GetValorMinimo());
            }
        }

        public int GetValorMaximo()
        {
            if(this.der == null)
            {
                return this.num;
            }
            else
            {
                return(der.GetValorMaximo());
            }
        }

        public ArrayList GetInOrder()
        {
            ArrayList arr = new ArrayList();
            numeros(arr);
            return arr;
        }

        public int GetCantNodos()
        {
            return this.GetInOrder().Count;
        }

        private void numeros(ArrayList arreglo)
        {
            if(this.izq != null)
            {
                this.izq.numeros(arreglo);
            }

            arreglo.Add(this.GetNum());

            if(this.der != null)
            {
                this.der.numeros(arreglo);
            }
        }

        public int GetAltura()
        {
            int cantIzq = Altitud(this.izq);
            int cantDer = Altitud(this.der);

            if(cantIzq > cantDer)
            {
                return cantIzq;
            }
            else
            {
                return cantDer;
            }

        }

        public int Altitud(Nodo n)
        {
            if(n == null)
            {
                return 0;
            }
            if((n.der == null) && (n.izq == null))
            {
                return 1;
            }

            int izquierda = Altitud(n.izq);
            int derecha = Altitud(n.der);

            if(izquierda > derecha)
            {
                return izquierda+1;
            }
            else
            {
                return derecha+1;
            }
        }

    }




}
