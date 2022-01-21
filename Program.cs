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

            m1[0, 0] = int.Parse(Console.ReadLine());
            m1[0, 1] = int.Parse(Console.ReadLine());
            m1[0, 2] = int.Parse(Console.ReadLine());
            m1[1, 0] = int.Parse(Console.ReadLine());
            m1[1, 1] = int.Parse(Console.ReadLine());
            m1[1, 2] = int.Parse(Console.ReadLine());

            #endregion

            #region definindo as matrizes #2

            m2[0, 0] = int.Parse(Console.ReadLine());
            m2[0, 1] = int.Parse(Console.ReadLine());
            m2[1, 0] = int.Parse(Console.ReadLine());
            m2[1, 1] = int.Parse(Console.ReadLine());
            m2[2, 0] = int.Parse(Console.ReadLine());
            m2[2, 1] = int.Parse(Console.ReadLine());

            #endregion

            #region calculos 

            // mRes[0, 0] = m1[0, 0] * m2[0, 0] + m1[0, 1] * m2[1,0] + m1[0,2] 

            #endregion

        }
    }
}
