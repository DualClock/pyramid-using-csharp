using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Peramide
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CreatePiramide(10);
        }
        static void CreatePiramide(int hight)
        {
            for (int i = 0; i < hight; i++)
            {
                for (int j=0; j < hight - 1 - i; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 0; k < (hight - (hight-1)) + i * 2; k++)
                {
                    Console.Write('*');
                }
                Console.WriteLine();
                
            }
        }
    }
}
