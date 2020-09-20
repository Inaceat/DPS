using System;
using System.Collections.Generic;
using System.Threading;

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


            leftMatrix.PrintToConsole();
            rightMatrix.PrintToConsole();
        
            multipliedSingle.PrintToConsole();
            multipliedMulti.PrintToConsole();

            multipliedSingle.PrintToFile("../../data/single.txt");
            multipliedMulti.PrintToFile("../../data/multi.txt");
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


        static void MultiplyPartOfMatrix(object input)
        { 
            var parameters = ((SquareMatrix left, SquareMatrix right, double[] resultStorage, int startIndex, int size)) input;

            for (int i = parameters.startIndex; i < parameters.startIndex + parameters.size; i++)
            {
                int row = i / parameters.left.Size;
                int column = i % parameters.left.Size;
                
                parameters.resultStorage[i] = 0;

                for (int k = 0; k < parameters.left.Size; k++)
                    parameters.resultStorage[i] += parameters.left[row, k] * parameters.right[k, column];

            }
        }

        private static SquareMatrix MultiplyInMultiThread(SquareMatrix left, SquareMatrix right, int threadsToUse)
        {
            if (left.Size != right.Size)
                throw new ArgumentException("Can't multiply: different size");

            int totalElements = left.Size * left.Size;

            var resultElements = new double[left.Size * left.Size];

            
            int threadDataSize, lastThreadDataSize;
	
            if(0 == totalElements % threadsToUse)
            {
                threadDataSize = totalElements / threadsToUse;
                lastThreadDataSize = 0;
            }
            else
            {
                threadDataSize = totalElements / threadsToUse + 1;
                --threadsToUse;
                lastThreadDataSize = totalElements - threadDataSize * threadsToUse;
		
            }

            //Create threads
            var threads = new List<Thread>(threadsToUse);
            Thread lastThread = null;
	
            //Do work for "equal-sized" threads
            for(int i = 0; i < threadsToUse; ++i)
            {
                threads.Add(new Thread(MultiplyPartOfMatrix));
                threads[i].Start((left, right, resultElements, i * threadDataSize, threadDataSize));
            }
	
            //Do work for "complement" thread, if present
            if (0 != lastThreadDataSize)
            {
                lastThread = new Thread(MultiplyPartOfMatrix);
                lastThread.Start((left, right, resultElements, threadsToUse * threadDataSize, lastThreadDataSize));
            }
	
            //Wait for workers
            foreach (var thread in threads)
                thread.Join();

            //Wait for last worker, if present
            if (0 != lastThreadDataSize)
                lastThread.Join();

	        
            return new SquareMatrix(left.Size, resultElements);
        }
    }
}
