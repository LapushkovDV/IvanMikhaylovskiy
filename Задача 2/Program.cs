using System;
using System.Windows.Forms;

namespace Задача_2
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
    class zadacha2
    {
        public int[,] array1;
        public int[,] array2;
        public int[,] array3;

        public void createarray(int i, int j)
        {
            array1 = new int[i, j];
            array2 = new int[i, j];
            array3 = new int[i, j];
        }

        public int[,] add_up_the_matrices(int[,] arr1, int[,] arr2)
        {
            int rows = arr1.GetLength(0);
            int col = arr2.GetLength(1);
            int[,] arr3 = new int[rows, col];
            for (int i = 0; i < rows; i++)
                for (int j = 0; j < col; j++)
                {
                    arr3[i, j] = arr1[i, j] + arr2[i, j];
                }
            return arr3;
        }
 
        public int[,] subtract_matrices(int[,] arr1, int[,] arr2)
        {
            int rows = arr1.GetLength(0);
            int col = arr2.GetLength(1);
            int[,] arr3 = new int[rows, col];
            for (int i = 0; i < rows; i++)
                for (int j = 0; j < col; j++)
                {
                    arr3[i, j] = arr1[i, j] - arr2[i, j];
                }
            return arr3;
        }
        
    }


}