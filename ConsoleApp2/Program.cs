using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("N times N multiplication table with array-nested loops - !press enter a number for the table!");

            int n = Int32.Parse(Console.ReadLine()); ; //multiplication table dimension

            int[,] q = new int[n, n];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    q[i, j] = (i + 1) * (j + 1);
                }
            }

            for (int i = 0; i < n; i++)
            {
                Console.Write($"\t{i + 1}");
            }

            Console.WriteLine();//insert a newline


            for (int i = 0; i < n; i++)
            {
                Console.Write($"{i + 1}");
                for (int j = 0; j < n; j++)
                {
                    Console.Write($"\t{q[j, i]}");
                }
                Console.WriteLine();//insert a newline

            }

            Console.ReadLine();
        }
    }
}
