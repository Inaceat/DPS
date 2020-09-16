using System;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            int threadCount = 4;

            int matrixSize = 5;
            var leftMatrix = SquareMatrix.Random(matrixSize);
            var rightMatrix = SquareMatrix.Random(matrixSize);

            var multipliedSingle = MultiplyInSingleThread(leftMatrix, rightMatrix);
            var multipliedMulti = MultiplyInMultiThread(leftMatrix, rightMatrix, threadCount);


            leftMatrix.Print();
            rightMatrix.Print();
        
            multipliedSingle.Print();
            multipliedMulti.Print();
        }

        private static SquareMatrix MultiplyInSingleThread(SquareMatrix left, SquareMatrix right)
        {
            if (left.Size != right.Size)
                throw new ArgumentException("Can't multiply: different size");

            var elements = new double[left.Size * left.Size];

            for (var row = 0; row < left.Size; ++row)
            {
                for (var column = 0; column < left.Size; ++column)
                {
                    elements[row * left.Size + column] = 0;

                    for (var k = 0; k < left.Size; ++k)
                        elements[row * left.Size + column] += left[row, k] * right[k, column];
                }
            }

         
   return new SquareMatrix(left.Size, elements);
        }

        private static SquareMatrix MultiplyInMultiThread(SquareMatrix left, SquareMatrix right, int threadsToUse)
        {
            if (left.Size != right.Size)
                throw new ArgumentException("Can't multiply: different size");

            var elements = new double[left.Size * left.Size];

            



            return new SquareMatrix(left.Size, elements);
        }
    }
}
