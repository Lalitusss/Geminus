using System;

namespace Ejercicio2
{
    class Program
    {
        static int[] myArray = new int[] { 1, 2, -1, 1, 0, 1, 2, -1, -1, -2 };
        static int n = 4;
        static int nLim = n - 1;
        public static void Main(string[] args)
        {
            var m = new string[n, n];
            Console.WriteLine("Arreglo Inicial");
            for (int f = 0; f < m.GetLength(0); f++)
            {
                for (int c = 0; c < m.GetLength(1); c++)
                {
                    if (f == 0 && c == 0)
                    {
                        m[f, c] = "X";
                    }
                    else
                    {
                        m[f, c] = "O";
                    }
                   Console.Write(m[f, c] + " ");
                }
                Console.WriteLine(" ");
            }
            Console.WriteLine(" ");
            Console.WriteLine("Movemos la X según la Matriz: " + "1, 2 / -1, 1 / 0, 1 / 2, -1 / -1, -2");
            for (int myArrayp = 0; myArrayp < myArray.Length; myArrayp++)
            {
                int H_V = myArrayp % 2;
                int content = myArray[myArrayp];
                bool band = true;
                switch (H_V)
                {
                    case 0:
                        for (int f = 0; f < m.GetLength(0); f++)
                        {
                            for (int c = 0; c < m.GetLength(1); c++)
                            {
                                if (m[f, c] == "X" && band)
                                {
                                    var col = (c + content) >= nLim ? nLim : (c + content);
                                    m[f, col] = "X";
                                    if (content != 0 && (c + content <= nLim))
                                    {
                                        m[f, c] = "O";
                                    }
                                    band = false;
                                }
                            }
                        }
                        break;
                    case 1:
                        for (int f = 0; f < m.GetLength(0); f++)
                        {
                            for (int c = 0; c < m.GetLength(1); c++)
                            {
                                if (m[f, c] == "X" && band)
                                {
                                    var fila = (f + content) >= nLim ? nLim : (f + content);
                                    m[fila, c] = "X";
                                    if (content != 0 && (f + content <= nLim))
                                    {
                                        m[f, c] = "O";
                                    }
                                    band = false;
                                }
                            }
                        }
                        break;
                    default:
                        break;
                }
            }

            for (int f = 0; f < m.GetLength(0); f++)
            {
                for (int c = 0; c < m.GetLength(1); c++)
                {

                    Console.Write(m[f, c] + " ");
                }
                Console.WriteLine(" ");
            }
            Console.ReadKey();
        }
    }
}
