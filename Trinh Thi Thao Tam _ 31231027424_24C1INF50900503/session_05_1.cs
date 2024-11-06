using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Trinh_Thi_Thao_Tam___31231027424_24C1INF50900503
{
    internal class session_05_1
    {
        //Cau 1: Write a C# function to find the maximum of three numbers
        static int maxofthreenumbers(int a, int b, int c)
        {
            return Math.Max(Math.Max(a, b), c);
        }
        // Cau 3: Write a C# function that takes a number as a parameter and checks whether the number is prime or not.
        static bool isPrime(int n)
        {
            if (n < 2) return false;
            for (int i = 2; i <= n / 2; i++)
            {
                if (n % 2 == 0)
                {
                    return false;
                }
            }
            return true;
        }
        // Cau 4a: print all prime numbers less than a number
        static void printPrimenumberunderN(int n)
        {
            for (int i = 2; i <= n; i++)
                if (isPrime(i))
                    Console.WriteLine(i);
        }
        // Cau 4b: the first N prime number
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
        // Cau 5: Write a C# function to check whether a number is "Perfect" or not. Then print all perfect number that less than 1000.
        static bool IsPerfectNumber(int n)
        {
            int sum = 0;
            if (n <= 0)
            {
                return false;
            }
            for (int i = 1; i <= n / 2; i++)
            {
                if (n % i == 0)
                {
                    sum += i;
                }
            }
            return sum == n;
        }
        public static void Main6()
        {
            //int m = maxofthreenumbers(7, 8, 9);
            //Console.WriteLine(m);
            Console.Write("Nhap mot so n:");
            int n = int.Parse(Console.ReadLine());
            if (isPrime(n))
            {
                Console.WriteLine($"{n} la so nguyen to");
            }
            else
                Console.WriteLine($"{n} khong la so nguyen to");
            //int result = theFactorialofNumber(n);
            //Console.WriteLine($"Giai thua cua {n} la {result}");
            //if (IsPerfectNumber(n))
            //{
            //    Console.WriteLine($"{n} la so hoan thien");
            //}
            //else
            //{
            //    Console.WriteLine($"{n} khong la so hoan thien");
            //}
            //Console.WriteLine($"So hoan thien nho hon 1000 la:");
            //for (int i = 1; i < 1000; i++)
            //{
            //    if (IsPerfectNumber(i))
            //    {
            //        Console.WriteLine(i);
            //    }
            //}
            Console.ReadKey();
        }
    }
}

