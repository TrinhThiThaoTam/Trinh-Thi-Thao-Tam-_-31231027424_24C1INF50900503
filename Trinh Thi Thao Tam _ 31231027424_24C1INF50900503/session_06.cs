using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trinh_Thi_Thao_Tam___31231027424_24C1INF50900503
{
    internal class session_06
    {
        public static void Main()
        {
            //Enter item values
            Console.Write("Nhap N:");
            int N = int.Parse(Console.ReadLine());
            int[] a;
            a = new int[N];
            nhap(a);
        }
        static void nhap(int[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine($"Nhap phan tu thu {i + 1}:");
                a[i] = int.Parse(Console.ReadLine());
            }
            //Print the array to screen
            static void InMang(int[] a)
            {
                for (int i = 0; i < a.Length; i++)
                {
                    Console.WriteLine($"Day array la: {a[i]}");
                }
                static void IncreaseEachItem(int[] a)
            //Adding it with 2
            {
                for (int i = 0; i < a.Length; i++)
                    {
                        a[i] += 2;
                        Console.WriteLine($"Gia tri item sau khi cong 2 la: {a[i]}");
                    }
            }
            }
        }
    }
}
