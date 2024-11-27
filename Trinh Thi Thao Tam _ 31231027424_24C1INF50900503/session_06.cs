using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trinh_Thi_Thao_Tam___31231027424_24C1INF50900503
{
    internal class session_06
    {
        public static void Main7()
        {
            //Enter item values
            Console.Write("Nhap N:");
            int N = int.Parse(Console.ReadLine());
            int[] a = new int[N];
            nhap(a);
            inmang(a);
            tang2(a);
            Console.ReadKey();
        }
        static void nhap(int[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write($"a[{i + 1}]=");
                a[i] = int.Parse(Console.ReadLine());
            }
        }
            //Print the array to screen
        static void inmang(int[] a) 
        {
             Console.Write($"Day array la: ");
             for (int i = 0; i < a.Length; i++)
                {
                    Console.Write(a[i] + " ");
                }
            Console.WriteLine();
        }
        static void tang2(int[] a)
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





