using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trinh_Thi_Thao_Tam___31231027424_24C1INF50900503
{
    internal class session_04
    {
        public static void Main()
        {
            //Question_01();
            //Question_02();
            //Question_03();
            //Question_04();
            //Question_05();
            //Question_06();
            Question_07();
            Console.ReadKey();
        }
        //Cau 1: Write a C# Sharp program to check whether a given number is even or odd.
        public static void Question_01()
        {
            Console.Write("Nhap mot so a:");
            int a = int.Parse(Console.ReadLine());
            if (a % 2 == 0)
            {
                Console.Write($"a la so chan");
            }
            else Console.Write($"a la so le");
        }
        //Cau 2: Write a C# Sharp program to find the largest of three numbers.
        public static void Question_02()
        {
            Console.Write("Nhap mot so a:");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Nhap mot so b:");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Nhap mot so c:");
            int c = int.Parse(Console.ReadLine());
            int Max = a;
            if (b > Max)
            {
                Max = b;
            }
            if (c > Max)
            {
                Max = c;
            }
            Console.Write($"So lon nhat la {Max}");
        }
        //Cau 3: Write a C# Sharp program to accept a coordinate point in an XY coordinate system and determine in which quadrant the coordinate point lies.
        public static void Question_03()
        {
            {
                Console.Write("Nhap toa do diem: \nX = ");
                int X = int.Parse(Console.ReadLine());
                Console.Write("Nhap toa do diem: :\n Y =");
                int Y = int.Parse(Console.ReadLine());
                if (X > 0 && Y > 0)
                {
                    Console.Write($"Toa do thuoc phan tu thu nhat");
                }
                else if (X > 0 && Y < 0)
                {
                    Console.Write($"Toa do thuoc phan tu thu bon");
                }
                else if (X < 0 && Y < 0)
                {
                    Console.Write($"Toa do thuoc phan tu thu ba");
                }
                else if (X < 0 && Y > 0)
                {
                    Console.Write($"Toa do thuoc phan tu thu hai");
                }
                else if (X == 0 && Y == 0)
                {
                    Console.Write($"Diem nam ngay goc toa do");
                }
            }
        }
        //Cau 4: Write a program to check whether a triangle is Equilateral, Isosceles or Scalene.
        public static void Question_04()
        {
            Console.Write("Nhap do dai canh a:");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Nhap do dai canh b:");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Nhap do dai canh c");
            int c = int.Parse(Console.ReadLine());
            if ((a == b) && (b == a) && (c == a))
            {
                Console.Write($"Day la tam giac deu");
            }
            else if ((a == b) || (b == c) || (c == a))
            {
                Console.Write($"Day la tam giac can");
            }
            else Console.Write($"Day la tam giac can");
        }
        //Cau 5: Write a program to read 10 numbers and find their average and sum.
        public static void Question_05()
        {
            int i, sum = 0;
            float avg;
            Console.Write("10 so la \n");
            for (i = 1; i < 11; i++)
            {
                Console.Write("{0} \n", i);
                sum += i;
                avg = sum / 10.0f;
            }
            Console.WriteLine($"Tong 10 so la: {sum}");
            Console.Write($"Trung binh 10 so la: avg = {sum / 10.0f}");
        }
        //Cau 6: Write a program to display the multiplication table of a given integer
        public static void Question_06()
        {
            Console.Write("Nhap 1 so nguyen co trong bang nhan");
            int number = int.Parse(Console.ReadLine());
            for (int i = 2; i <= number; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    Console.WriteLine($"{i} * {j} = {i * j}");
                }
            }
            Console.WriteLine();
        }
        //Cau 7: Write a program to display a pattern like triangles with a number.
        public static void Question_07()
        {
            Console.Write("Nhap so dong:");
            int rows = int.Parse(Console.ReadLine());
            Console.WriteLine();
            for (int i = 1; i <= rows; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j + " ");
                }
            }
            Console.WriteLine();
        }
    }
}

