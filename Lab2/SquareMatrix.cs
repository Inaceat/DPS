using System;
using System.IO;
using System.Text;

namespace Lab2
{
    class SquareMatrix
    {
        public int Size { get; }

        private readonly double[] _elements;


        public double this[int row, int column] => _elements[row * Size + column];
        public double this[int elementIndex] => _elements[elementIndex];


        public SquareMatrix(int size, double[] elements)
        {
            if (size <= 0)
                throw new ArgumentException("Negative size");

            Size = size;

            if (elements.Length != Size * Size)
                throw new ArgumentException("Invalid array size");

            _elements = new double[size * size];
            elements.CopyTo(_elements, 0);
        }

        public static SquareMatrix Random(int size)
        {
            if (size <= 0)
                throw new ArgumentException("Negative size");


            var randomElements = new double[size * size];

            var rng = new Random((int) DateTime.Now.Ticks);

            for (var i = 0; i < size * size; i++)
                randomElements[i] = rng.NextDouble() * 100;

            return new SquareMatrix(size, randomElements);
        }

        public void PrintToConsole()//yea yea, SRP
        {
            for (var i = 0; i < Size; i++)
            {
                var line = new StringBuilder();

                for (var j = 0; j < Size; j++)
                    line.Append($"{this[i, j], 10:F2}");

                Console.WriteLine(line);
            }

            Console.WriteLine();
        }

        public void PrintToFile(string path)//yea yea, SRP
        {
            using (FileStream outFile = File.OpenWrite(path))
            using (var writer = new StreamWriter(outFile))
            {
                for (var i = 0; i < Size; i++)
                {
                    var line = new StringBuilder();

                    for (var j = 0; j < Size; j++)
                        line.Append($"{this[i, j],10:F2}");

                    writer.WriteLine(line);
                }
            }
        }
    }
}
