using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trinh_Thi_Thao_Tam___31231027424_24C1INF50900503
{
    internal class session_07
    {
        //Create an integer matrix N x M (N,M was prompted from user) randomly.
        static void NhapMangNgauNhien(int[,]a, int rows, int columns)
        {
            Random random = new Random();
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    a[i, j] = random.Next(0, 100);
                }    
            }
        }
        //Print the matrix.
        static void InMang(int[,] a)
        {
            for (int i = 0;i < a.GetLength(0); i++)
            {
                for (int j = 0;j < a.GetLength(1); j++)
                {
                    Console.Write(a[i,j] + "\t");
                }
                Console.WriteLine();
            }    
        }
        //Print the ith row/column. (i was prompted from user)
        static void InGiaTri(int[,] a, int value)
        {
            for (int i = 0; i <a.GetLength(0); i++)
            {
                for (int j = 0; j<a.GetLength(1); j++)
                {
                    if (a[i,j] == value)
                    {
                        Console.WriteLine($"{value} xuat hien tai dong {i} cot {j} \n");
                    }
                }
            }
        }
        //Find the max value of the matrix.
        static void TimGiaTriLonNhat(int[,] a)
        {
            int max = a[0, 0];
            for (int i = 0; i<a.GetLength(0); i++)
            {
                for (int j = 0; j<a.GetLength(1); j++)
                {
                    if (a[i,j] > max)
                    {
                        max = a[i,j];
                    }
                }
            }
            Console.WriteLine($"Gia tri lon nhat la: {max}");
        }
        //Find the min value of ith row/col of the matrix
        static void TimGiaTriNhoNhatCuaDong(int[,] a) 
        {
            for (int i = 0; i<a.GetLength(0);i++)
            {
                int min = a[i, 0];
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    if (a[i,j] < min)
                    {
                        min = a[i,j];
                    }
                }
                Console.WriteLine($"Gia tri nho nhat dong {i} la: {min}");
            }
        }
        //Transpose the matrix
        static void ChuyenVi(int[,] a, ref int[,]b) //lay truc tiep gia tri truyen vao de su dung luon de khong copy gia tri cua ma tran a
        {
            int rowsa = a.GetLength(0);
            int colsa = a.GetLength(1);
            b = new int[colsa , rowsa];
            for (int i = 0; i < rowsa;i++)
            {
                for (int j = 0; j < colsa; j++)
                {
                    b[j,i] = a[i,j]; 
                }
            }
            Console.WriteLine($"Ma tran sau khi chuyen vi la:");
        }
        //Print the transposed matrix
        static void InMaTranChuyenVi(int[,] b)
        {
            for (int i = 0;i < b.GetLength(0);i++)
            {
                for (int j=0; j < b.GetLength(1); j++)
                {
                    Console.Write(b[i, j] + "\t");
                }
                Console.WriteLine(); //new line after each row 
            }
        }
        private static void Main8(string[] args)
        {
            int[,] a;
            int[,] b = null; // khoi tao gia tri
            Console.Write($"Nhap so dong: "); int rows = int.Parse( Console.ReadLine() );
            Console.Write($"Nhap so cot: "); int columns = int.Parse( Console.ReadLine() );
            a = new int[rows, columns];
            b = new int[columns, rows];
            NhapMangNgauNhien(a, rows, columns);
            InMang(a);
            //Console.Write("Nhap so can tim: ");
            //int val = int.Parse( Console.ReadLine() );
            //InGiaTri(a, val);
            //TimGiaTriLonNhat(a);
            //TimGiaTriNhoNhatCuaDong(a);
            ChuyenVi(a,ref b);
            InMaTranChuyenVi(b);
        }
    }
}
