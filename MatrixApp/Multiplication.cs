using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixApp
{
    class Multiplication
    {
        public void Multiplicat()

        {
            try

            {
                string rowa, columna, rowb, columnb, m, n;

                int[,] a = new int[4, 4];

                int[,] b = new int[4, 4];

                int[,] c = new int[4, 4];


                int i = 0, j = 0, k = 0, l = 0;

                c[i, j] = 0;

                int noOfRowa = 0, noOfColumna = 0, noOfRowb= 0, noOfColumnb= 0;


                Console.WriteLine(" Enter number of rows for matrix A");

                rowa = Console.ReadLine();

                noOfRowa = Convert.ToInt32(rowa);

                Console.WriteLine(" Enter number of columns for matrix A");
                Console.WriteLine("\n ..................................");

                columna = Console.ReadLine();

                noOfColumna = Convert.ToInt32(columna);

                Console.WriteLine(" Enter the number of rows for matrix B");

                rowb = Console.ReadLine();

                noOfRowb= Convert.ToInt32(rowb);

                Console.WriteLine(" Enter the number of columns for matrix B");
                Console.WriteLine("\n ..................................");


                columnb = Console.ReadLine();

                noOfColumnb= Convert.ToInt32(columnb);

                Console.WriteLine(" The values of A matrix is :");
                Console.WriteLine("\n ..................................");


                for (i = 0; i < noOfRowa; i++)

                {

                    for (j = 0; j < noOfColumna; j++)

                    {
                        m = Console.ReadLine();

                        k = Convert.ToInt32(m);

                        a[i, j] = k;
                    }
                }
                Console.WriteLine(" The values of B matrix is :");

                for (i = 0; i < noOfRowb; i++)
                    {

                    for (j = 0; j < noOfColumnb; j++)

                    {
                        n = Console.ReadLine();

                        l = Convert.ToInt32(n);

                        b[i, j] = l;

                    }

                }

                Console.WriteLine(" The matrix format of A is ");

                for (i = 0; i < noOfRowa; i++)

                {

                    for (j = 0; j < noOfColumna; j++)

                    {

                        Console.Write(" {0}", a[i, j]);

                    }

                    Console.WriteLine("");

                }

                Console.WriteLine(" The matrix format of B is ");

                for (i = 0; i < noOfRowb; i++)

                {

                    for (j = 0; j < noOfColumnb; j++)

                    {

                        Console.Write(" {0}", b[i, j]);

                    }

                    Console.WriteLine("");

                }

                if (columna == rowb)

                {

                    for (i = 0; i < noOfRowa; i++)

                    {

                        for (j = 0; j < noOfColumnb; j++)

                        {

                            c[i, j] = (a[i, 0] * b[0, j]) + (a[i, 1] * b[1, j]);

                            Console.Write("  ");

                        }

                        Console.WriteLine("");
                    }
                }
                else

                {
                    Console.WriteLine("The matrix multiplication cannot be performed: Logic violation");
                }
                Console.WriteLine("\n ..................................");
               Console.WriteLine(" The resultant matrix is");

                for (i = 0; i < noOfRowa; i++)

                {
                    for (j = 0; j < noOfColumnb; j++)
                    {
                        Console.Write("{0}", c[i, j]);
                    }
                    Console.WriteLine();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
       
    }
    
}