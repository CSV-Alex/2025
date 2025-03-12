using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter06
{
    class Exercise18
    {
        public void Execute()
        {
            Console.WriteLine("Enter the (n) dimension of the Matrix: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("-----------------------------------------------");
            int[,] mat = new int[n, n];
            int value = 1;
            int top = 0, bottom = n - 1, left = 0, right = n - 1;

            while (value <= n * n)
            {
                for (int i = left; i <= right; i++)
                    mat[top, i] = value++;
                top++;

                for (int i = top; i <= bottom; i++)
                    mat[i, right] = value++;
                right--;

                for (int i = right; i >= left; i--)
                    mat[bottom, i] = value++;
                bottom--;

                for (int i = bottom; i >= top; i--)
                    mat[i, left] = value++;
                left++;
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                    Console.Write(mat[i, j] + " ");
                Console.WriteLine();
            }
        }
    }
}
