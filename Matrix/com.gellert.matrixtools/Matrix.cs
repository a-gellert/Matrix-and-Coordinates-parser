using System;

namespace MatrixTools.com.gellert.matrixtools
{   
/// <summary>
/// Клас для управленя матрицами
/// </summary>
    class Matrix
    {/// <summary>
    ///Автоматические свойства
    /// </summary>
        public int Row { get; set; }
        public int Column { get; set; }

        public int[,] MatrixTemp { get; }
        /// <summary>
        /// Контсруктор класса
        /// </summary>
        /// <param name="column"></param>
        /// <param name="row"></param>
        public Matrix(int column, int row)
        {
            Row = row;
            Column = column;
            MatrixTemp = new int[Column, Row];
        }

        private static Random rand = new Random();
        /// <summary>
        /// Метод заполнения матрицы
        /// </summary>
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
        /// <summary>
        /// Метод суммирования матриц
        /// </summary>
        /// <param name="matrixA"></param>
        /// <param name="matrixB"></param>
        /// <returns>Матрица или пустое значение</returns>
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
        /// <summary>
        /// Метод перемножения матриц
        /// </summary>
        /// <param name="matrixA"></param>
        /// <param name="matrixB"></param>
        /// <returns>Матрица или пустое значение</returns>
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
        /// <summary>
        /// Метод вывода матрицы на консоль
        /// </summary>
        /// <param name="matrix"></param>
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
