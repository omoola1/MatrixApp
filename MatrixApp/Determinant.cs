using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MATRIX
{
    class MatrixDet

    {
        public void Determ()
        {

            {
                int i, j;
                    int determinant = 0;
                    

                    int[,] multiDim =  {
                                        {8,4,3,6},
                                        {5,8,7,8},
                                        {8,8,3,4},
                                        {6,5,8,1}

                 };

                    Console.Write("\n\nDeterminant of 4 x 4 Matrix :\n");
                    Console.Write("-------------------------------------------------\n");

                    Console.Write("Input the elements of the Matrix :\n");
                    for (i = 0; i < 4; i++)
                    {
                        for (j = 0; j < 4; j++)
                        {
                            Console.Write("", i, j);
                            multiDim[i, j] = Convert.ToInt32(Console.ReadLine());
                        }
                    }
                    Console.Write("The matrix is :\n");
                    for (i = 0; i < 4; i++)
                    {
                        for (j = 0; j < 4; j++)
                            Console.Write("{0}  ", multiDim[i, j]);
                        Console.Write("\n");
                    }

                    for (i = 0; i < 4; i++)
                        determinant = determinant + (multiDim[0, i] * (multiDim[1, (i + 1) % 4] * multiDim[2, (i + 2) % 4] * multiDim[3, (i + 3) % 4] - multiDim[1,(i + 2) % 4] * multiDim[2, (i + 1) % 4]));

                    Console.Write("\nThe determinant of the matrix is: {0}\n\n", determinant);

                }
            }
        }
    }

