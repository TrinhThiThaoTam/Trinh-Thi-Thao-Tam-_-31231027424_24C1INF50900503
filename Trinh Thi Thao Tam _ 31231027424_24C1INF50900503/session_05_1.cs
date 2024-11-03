using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace Trinh_Thi_Thao_Tam___31231027424_24C1INF50900503
{
    internal class session_05_1
    {
        static int maxofthreenumbers(int a, int b, int c)
        {
            return Math.Max(Math.Max(a, b), c);
        }
        static bool isPrime(int number)
        {
            if (number < 2) return false;
            for (int i = 2; i <= number / 2; i++)
                if (number % 2 == 0)
                    return false;
            return true;
        }
        static void printPrimenumberunderN(int n)
        {
            for (int i = 2; i <= n; i++)
                if (isPrime(i))
                    Console.WriteLine(i);
        }
        static void printfirstNprime(int n)
        {
            int so = 2;
            int dem = 0;
            while (dem < n)
            {
                if (isPrime(so))
                {
                    Console.Write(so + " ");
                    dem++;
                }
                so++;
            }
        }
        //Cau2: Write a C# function to calculate the factorial of a number (a non-negative integer). The function accepts the number as an argument.
        static int theFactorialofNumber (int n)
        {
            int result = 1;
            for (int i = 1; i <= n; i++)
            {
                result = result * i; //hoac co the la result *= i;
            }
            return result;
        }
        public static void Main()
        {
            //int m = maxofthreenumbers(7, 8, 9);
            //Console.WriteLine(m);
            Console.Write("Nhap mot so n:");
            int n = int.Parse(Console.ReadLine());
            int result = theFactorialofNumber(n);
            Console.WriteLine($"Giai thua cua {n} la {result}");
            Console.ReadKey();
        }
    }
}

