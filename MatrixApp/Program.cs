using MATRIX;
using System;

namespace MatrixApp
{
    class Matrices
    {
        static void Main(string[] args)
        {
            
            Multiplication mult = new Multiplication();
            MatrixDet determinant = new MatrixDet();
            Dot product = new Dot();    

            Console.WriteLine("WELCOME TO WORLD OF 4*4 MATRIX");
            Console.WriteLine("\n Select the task to perform");
            Console.WriteLine("\n1 Determinnt of Matrix 4*4\n2 Multiplication of Two Matrices 4*4\n3 Dot  Product of Matrix 4*4");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine("\n ..................................");

            if (num == 1)
            {
                determinant.Determ();
                return;

            }
            if (num == 2)
            {
                mult.Multiplicat();
                return;

            }
            if (num == 3)
            {
                product.DotMatrix();
                return;
            }
        }
        
    }
}
