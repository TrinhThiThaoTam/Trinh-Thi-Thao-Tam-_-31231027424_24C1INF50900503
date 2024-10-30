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
        static void printPrimenumberUnderN(int n)
        {
            for (int i = 2; i <= n; i++)
                if (isPrime(i))
                    Console.WriteLine(i);
        }
        public static void Main()
        {
            int m = maxofthreenumbers(7, 8, 9);
            Console.WriteLine(m);
            Console.ReadKey();
        }
    }
}

