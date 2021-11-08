using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixApp
{
    public class Dot
    {


        public void DotMatrix()
        {
            int i, j;
            int[,] a = new int[4, 4];
            int[,] b = new int[4, 4];
            int[] c = new int[4];

            Console.WriteLine("Enter the Element of Matrix A");

            for (i = 0; i < 4; i++)
                for (j = 0; j < 4; j++)
                  a[i, j] = int.Parse(Console.ReadLine());

                    Console.WriteLine("Enter the Element of Matrix B");
                  
                    for (i = 0; i < 4; i++)
                        for (j = 0; j < 4; j++)
                            b[i, j] = int.Parse(Console.ReadLine());
                            for (i = 0; i < 4; i++)
                            {
                                c[i] = 0;

                                for (j = 0; j < 4; j++)
                                    c[i] += a[i, j] * b[i, j];
                            }

            Console.WriteLine("\n ........................................");
            Console.WriteLine("\n The Dot Product of the Matrices is:");
                            for (i = 0; i < 4; i++)
                                Console.WriteLine(c[i]);
                            Console.ReadKey();
        }
    }
}

