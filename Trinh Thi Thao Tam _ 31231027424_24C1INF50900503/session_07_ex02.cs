using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Trinh_Thi_Thao_Tam___31231027424_24C1INF50900503
{
    internal class session_07_ex02
    {
    //Create a jagged array and initialize it using the following values for its rows and columns; Then, display it.
          //1 1 1 1 1
          //2 2
          //3 3 3 3
          //4 4
     static void CreateJaggedArray()
        {
            int[][] jaggedArray = {
            new int[] { 1, 1, 1, 1 },
            new int[] { 2, 2 },
            new int[] { 3, 3, 3, 3 },
            new int[] { 4, 4 },
            };
            Console.WriteLine("Jagged array la:");
            for (int i = 0; i < jaggedArray.Length; i++) //give the size of jagged array
            {
                for (int j = 0; j < jaggedArray[i].Length; j++) //give the size of elements of the ith array inside the jagged array
                {
                    Console.Write(jaggedArray[i][j] + " " );
                }
                Console.WriteLine();
            }
        }
        //Create a Jagged Array with random integer numbers (or by user input) by getting the number of rows and columns from the user and printing the data in the array to the user
    static void NhapMaTranTuDong(int[][] jaggedArray)
        {
            Random random = new Random();
            for (int i = 0; i < jaggedArray.Length; i++)
            {
                for (int j = 0;j < jaggedArray[i].Length; j++)
                {
                    jaggedArray[i][j] = random.Next(0, 100);
                }
            }
        }
        //Print the biggest number of each row and the largest number of the whole array.
        static void SoLonNhat(int[][] jaggedArray)
        {
            int maxoverall = jaggedArray[0][0];
            for (int i = 0;i < jaggedArray.Length; i++)
            {
                int maxrow = jaggedArray[i][0];
                for (int j = 0; j < jaggedArray[i].Length; j++)
                {
                    if (jaggedArray[i][j] > maxrow)
                    {
                        maxrow = jaggedArray[i][j];
                    }
                }
                Console.WriteLine($"So lon nhat cua dong {i + 1} la: {maxrow}");
                if (maxrow > maxoverall)
                {
                    maxoverall = maxrow;
                }
            }
            Console.WriteLine($"So lon nhat cua ma tran la: {maxoverall}");
        }
        //Sort values ascending of each row
        static void SortValueEachRow(int[][] jaggedArray)
        {
            foreach (int[] row in jaggedArray)
            {
                for (int i = 0; i < row.Length; i++)
                {
                    for (int j = 0; j < i; j++)
                    {
                        if (row[i] < row[j])
                        {
                            int temp = row[i];
                            row[i] = row[j];
                            row[j] = temp;
                        }
                    }
                }
            }
        }
        static bool isPrime(int n)
        {
            if (n <= 1) return false;
            for (int i = 2; i < Math.Sqrt(n); i++)
            {
                if (n % i == 0) return false;
            }
            return true;
        }
        static void PrintPrimeNumber(int[][] jaggedArray)
        {
            Console.WriteLine("So nguyen to trong ma tran la:");
            for (int i = 0; i < jaggedArray.Length; i++)
            {
                for (int j = 0; j < jaggedArray[i].Length; j++)
                {
                    if (isPrime(jaggedArray[i][j]))
                    {
                        Console.Write(jaggedArray[i][j] + "\t");
                    }
                }
            }
            Console.WriteLine();
        }
        private static void Main()
        {
            //CreateJaggedArray();
            Console.Write("Nhap so dong: ");
            int rows = int.Parse(Console.ReadLine());
            int [][] jaggedArray = new int[rows][];
            for (int i = 0; i < rows; i++)
            {
                Console.Write($"Nhap so cot cho dong {i + 1}: ");
                int cols = int.Parse(Console.ReadLine());
                jaggedArray[i] = new int[cols];
            }
            Console.WriteLine("Ma tran da tao: ");
            NhapMaTranTuDong(jaggedArray);
            for (int i = 0;i < jaggedArray.Length; i++)
            {
                for (int j = 0; j < jaggedArray[i].Length; j++)
                {
                    Console.Write(jaggedArray[i][j] + "\t");
                }
                Console.WriteLine();
            }
            SoLonNhat(jaggedArray);
            Console.Write("Nhap dong can sort: "); 
            SortValueEachRow(jaggedArray);
            PrintPrimeNumber(jaggedArray);
        }
    }
}
