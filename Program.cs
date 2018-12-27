using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Less2
{
    class Program
    {
        static void Main(string[] args)
        {
            const int INTEGER_ARRAY = 5;
            int[] integerNumbers = new int[INTEGER_ARRAY];
            const int ROW = 3, COLLUMN = 4;
            double[,] fractionalNumbers = new double[ROW, COLLUMN];
            Console.WriteLine("Enter 5 integer numbers");

            int maximumIntegerNumber = 0;
            int minimalIntegerNumber = 0;
            for (int i = 0; i < INTEGER_ARRAY; i++)
            {
                integerNumbers[i] = Convert.ToInt32(Console.ReadLine());
                if (maximumIntegerNumber < integerNumbers[i])
                {
                    maximumIntegerNumber = integerNumbers[i];
                }
                if (minimalIntegerNumber > integerNumbers[i])
                {
                    minimalIntegerNumber = integerNumbers[i];
                }
            }

            Random random = new Random();
            double maximumFractionalNumber = 0;
            double minimalFractionalNumber = 0;
            for (int i = 0; i < ROW; i++)
            {
                for (int j = 0; j < COLLUMN; j++)
                {
                    double randomNumber = random.Next(0, 100);
                    fractionalNumbers[i, j] = randomNumber;
                    if (maximumFractionalNumber < fractionalNumbers[i, j])
                    {
                        maximumFractionalNumber = fractionalNumbers[i, j];
                    }
                    if (minimalFractionalNumber > fractionalNumbers[i, j])
                    {
                        minimalFractionalNumber = fractionalNumbers[i, j];
                    }
                }
            }

            double maximumNumber = 0;
            double minimalNumber = 0;

            if (maximumFractionalNumber > maximumIntegerNumber)
            {
                maximumNumber = maximumFractionalNumber;
            }
            else
            {
                maximumNumber = maximumIntegerNumber;
            }

            if (minimalFractionalNumber < minimalIntegerNumber)
            {
                minimalNumber = minimalFractionalNumber;
            }
            else
            {
                minimalNumber = minimalIntegerNumber;
            }

            for (int i = 0; i < INTEGER_ARRAY; i++)
            {
                Console.Write(integerNumbers[i] + " ");
            }
            Console.Write("\n");

            for (int i = 0; i < ROW; i++)
            {
                for (int j = 0; j < COLLUMN; j++)
                {
                    Console.Write(fractionalNumbers[i, j] + " ");
                }
                Console.Write("\n");
            }

            

            Console.Read();
        }
    }
}
