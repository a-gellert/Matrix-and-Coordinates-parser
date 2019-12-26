using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixTools.com.gellert.matrixtools
{
    class Matrix
    {
        public int Row { get; set; }

        public int Column { get; set; }

        public int[,] MatrixTemp { get; }

        public Matrix(int column, int row)
        {
            Row = row;
            Column = column;
            MatrixTemp = new int[Column, Row];
        }

        private static Random rand = new Random();
        public void FillMatrix()
        {
            for (int i = 0; i < Column; i++)
            {
                for (int j = 0; j < Row; j++)
                {
                    MatrixTemp[i, j] = rand.Next(100);
                }
            }
        }

        public static Matrix SumMatrix(Matrix matrixA, Matrix matrixB)
        {
            if (matrixA.Column == matrixB.Column && matrixA.Row == matrixB.Row)
            {
                Matrix resultMass = new Matrix(matrixA.Column, matrixA.Row);
                for (int i = 0; i < matrixA.Column; i++)
                {
                    for (int j = 0; j < matrixA.Row; j++)
                    {
                        resultMass.MatrixTemp[i, j] = matrixA.MatrixTemp[i, j] + matrixB.MatrixTemp[i, j];
                    }
                }
                return resultMass;
            }
            else
            {
                Console.WriteLine("Размерности матриц не совпадают, сложение невозможно");
                return null;
            }

        }

        public static Matrix MultiplyMatrix(Matrix matrixA, Matrix matrixB)
        {
            if (matrixA.Column == matrixB.Column && matrixA.Row == matrixB.Row)
            {
                Matrix resultMass = new Matrix(matrixA.Column, matrixA.Row);
                for (int i = 0; i < matrixA.Column; i++)
                {
                    for (int j = 0; j < matrixA.Row; j++)
                    {
                        resultMass.MatrixTemp[i, j] = matrixA.MatrixTemp[i, j] * matrixB.MatrixTemp[i, j];
                    }
                }
                return resultMass;
            }
            else
            {
                Console.WriteLine("Размерности матриц не совпадают, умножение невозможно");
                return null;
            }
        }
        public static void ShowMatrix(Matrix matrix)
        {
            if (matrix != null)
            {
                for (int i = 0; i < matrix.Column; i++)
                {
                    for (int j = 0; j < matrix.Row; j++)
                    {
                        Console.Write($"{matrix.MatrixTemp[i, j]} ");
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
