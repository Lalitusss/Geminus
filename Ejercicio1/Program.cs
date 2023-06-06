using System;

namespace Ejercicio1
{
    class Program
    {
        static int n = 5;
        public static void Main(string[] args)
        {
            Console.WriteLine("Ejercicio 1");
            int nFilas = 0;
            do
            {
                Console.Write("Ingrese número de casillas:  ");
                try
                {
                    nFilas = int.Parse(Console.ReadLine());
                    if (nFilas < 1 || nFilas > 10)
                    {
                        nFilas = 5;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("No es un numero");
                }

            } while (nFilas < 1 || nFilas > 10);
            var m = new string[nFilas, nFilas];
            for (int f = 0; f < m.GetLength(0); f++)
            {
                for (int c = 0; c < m.GetLength(1); c++)
                {
                    int r = c % 2;
                    int restof = f % 2;
                    if (restof == 0)
                    {
                        if (r == 0)
                        {
                            m[f, c] = "X";
                        }
                        else
                        {
                            m[f, c] = "_";
                        }
                        Console.Write(m[f, c] + " ");
                    }
                    else
                    {
                        if (r == 0)
                        {
                            m[f, c] = "_";
                        }
                        else
                        {
                            m[f, c] = "X";
                        }
                        Console.Write(m[f, c] + " ");
                    }

                }
                Console.WriteLine("");
            }
            Console.ReadKey();
        }
    }
}
