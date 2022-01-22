using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calcular_matrizes_console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("###### CÁLCULO DE MATRIZES ########");
            
            #region matrizes
            int[,] m1 = new int[2,3];
            int[,] m2 = new int[3, 2];
            int[,] mRes = new int[2, 2];

            // aqui eu ja defini a quantidade de linhas e colunas das matrizes, além da matriz resultado
            #endregion

            #region definindo as matrizes #1

            Console.WriteLine("DEFINIR MATRIZ #1");

            Console.WriteLine("[x] [] []");
                Console.WriteLine("[] [] []");
                    Console.WriteLine("Escolha o número:");
                        m1[0, 0] = int.Parse(Console.ReadLine());
            
            Console.WriteLine("[] [x] []");
                Console.WriteLine("[] [] []");
                    Console.WriteLine("Escolha o número:");
                        m1[0, 1] = int.Parse(Console.ReadLine());

            Console.WriteLine("[] [] [x]");
                Console.WriteLine("[] [] []");
                    Console.WriteLine("Escolha o número:");
                        m1[0, 2] = int.Parse(Console.ReadLine());

            Console.WriteLine("[] [] []");
                Console.WriteLine("[x] [] []");
                    Console.WriteLine("Escolha o número:");
                        m1[1, 0] = int.Parse(Console.ReadLine());

            Console.WriteLine("[] [] []");
                Console.WriteLine("[] [x] []");
                    Console.WriteLine("Escolha o número:");
                        m1[1, 1] = int.Parse(Console.ReadLine());

            Console.WriteLine("[] [] []");
                Console.WriteLine("[] [] [x]");
                    Console.WriteLine("Escolha o número:");
                        m1[1, 2] = int.Parse(Console.ReadLine());

            #endregion

            #region definindo as matrizes #2

            Console.WriteLine("DEFINIR MATRIZ #2");

            Console.WriteLine("[x] []");
                Console.WriteLine("[] []");
                    Console.WriteLine("[] []");
                        Console.WriteLine("Escolha o número:");
                            m2[0, 0] = int.Parse(Console.ReadLine());

            Console.WriteLine("[] [x]");
                Console.WriteLine("[] []");
                    Console.WriteLine("[] []");
                        Console.WriteLine("Escolha o número:");
                            m2[0, 1] = int.Parse(Console.ReadLine());

            Console.WriteLine("[] []");
                Console.WriteLine("[x] []");
                    Console.WriteLine("[] []");
                        Console.WriteLine("Escolha o número:");
                            m2[1, 0] = int.Parse(Console.ReadLine());

            Console.WriteLine("[] []");
                Console.WriteLine("[] [x]");
                    Console.WriteLine("[] []");
                        Console.WriteLine("Escolha o número:");
                            m2[1, 1] = int.Parse(Console.ReadLine());

            Console.WriteLine("[] []");
                Console.WriteLine("[] []");
                    Console.WriteLine("[x] []");
                        Console.WriteLine("Escolha o número:");
                            m2[2, 0] = int.Parse(Console.ReadLine());

            Console.WriteLine("[] []");
                Console.WriteLine("[] []");
                    Console.WriteLine("[] [x]");
                        Console.WriteLine("Escolha o número:");
                            m2[2, 1] = int.Parse(Console.ReadLine());

            #endregion

            #region calculos 

            mRes[0, 0] = m1[0, 0] * m2[0, 0] + m1[0, 1] * m2[1, 0] + m1[0, 2] * m2[2, 0];
            mRes[0, 1] = m1[0, 0] * m2[0, 1] + m1[0, 1] * m2[1, 1] + m1[0, 2] * m2[2, 1];
            mRes[1, 0] = m1[1, 0] * m2[0, 0] + m1[1, 1] * m2[1, 0] + m1[1, 2] * m2[2, 0];
            mRes[1, 1] = m1[1, 0] * m2[0, 1] + m1[1, 1] * m2[1, 1] + m1[1, 2] * m2[2, 1];

            // aqui eu operei a matriz 1 pela matriz 2, para dar o resultado da matriz final
            #endregion

            #region resultado

            #endregion

        }
    }
}
