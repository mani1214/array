using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp4
{
    class Class1
    {
        static void Main(string[] args)
        {
            int[,] arr = { { 1, 2 }, { 3, 4 } };
            int[,] arr1 = { { 2, 5 }, { 5, 6 } };
            int[,] s = new int[2, 2];
            for(int i = 0; i < 2; i++)
            {
                for(int j=0;j<2;j++)
                {
                    s[i, j] = 0;
                    for(int k = 0; k < 2; k++)
                    {
                        s[i, j] = s[i, j] + arr[i, k] * arr1[j, k];
                    }
                    Console.Write(s[i,j]+" ");
                }
                Console.WriteLine();

            }
           
        }
    }
}
