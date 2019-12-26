using MatrixTools.com.gellert.matrixtools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixTools
{
    class Program
    {
        static void Main(string[] args)
        {
            Matrix matrix1 = new Matrix(6, 8);
            Matrix matrix2 = new Matrix(6, 7);

            matrix1.FillMatrix();
            matrix2.FillMatrix();

            Matrix.ShowMatrix(matrix1);
            Console.WriteLine();
            Matrix.ShowMatrix(matrix2);
            Console.WriteLine();
            
            Matrix result = Matrix.MultiplyMatrix(matrix1, matrix2);

            Matrix.ShowMatrix(result);
                       
            Console.ReadKey();
        }
    }
}
