using Microsoft.VisualBasic;
using System.Windows.Forms;

namespace Задача_1
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
    class zadacha1
    {
        public int[] MyArray;
      public void GenerateArray()
        {
            MyArray = new int[100];
            Random rnd = new Random();
            for (int i = 0; i< 100; i = i + 1)
            {
                MyArray[i] = rnd.Next(1,50);
            }
        }
       public void setMyArrayfromTextBox(string text)
        {
            string[] text_elemets = text.Split(';');
            
            if (MyArray != null) Array.Clear(MyArray);
            MyArray = Array.ConvertAll(text_elemets, s => int.Parse(s));
        }
       public float arithmetic_mean(int[] arr)
        {
            float res = 0;
            foreach (int i in arr)
            {
                res += i;
            }
            res = res / arr.Length;
            return res;
        }
        public double geometric_mean(int[] arr)
        {
            double res = 1;
            foreach (int i in arr)
            {
                res *= i;
            }
            res = Math.Pow(res, (double)1/(double)arr.Length);            
            return res;
        }
        public double quadratic_mean(int[] arr)
        {
            double res = 0;
            foreach (int i in arr)
            {
                res += i*i;
            }
            res = res / arr.Length;
            res = Math.Pow(res, 1.0/2.0);
            return res;
        }
        
    }

}