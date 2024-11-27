using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Threading.Tasks;

namespace Trinh_Thi_Thao_Tam___31231027424_24C1INF50900503
{
    internal class session_04
    {
        public static void Main4()
        {
            //Question_01();
            //Question_02();
            //Question_03();
            //Question_04();
            //Question_05();
            //Question_06();
            //Question_07();
            Question_08();
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
            else Console.Write($"Day la tam giac thuong");
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
            Console.Write("Nhap 1 so nguyen de thuc hien bang cuu chuong");
            int number = int.Parse(Console.ReadLine());
            for (int i = 2; i <= 10; i++)
            {
                Console.WriteLine($"{number} * {i} = {number * i}");
            }
        }
        //Cau 7: Write a program to display a pattern like triangles with a number.
        public static void Question_07()
        {
            Console.Write("Nhap so dong:");
            int rows = int.Parse(Console.ReadLine());
            int a = 1;
            Console.WriteLine("Tam giac can le trai");
            for (int i = 1; i <= rows; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j + "");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Tam giac can le trai nhung ma so tang dan");
            for (int i = 1; i <= rows; i++) //i la row
            {
                for (int j = 1; j <= i; j++) //j la col
                {
                    Console.Write("" + a); //a++ so tang dan
                    a++;
                }
                Console.WriteLine();
            }
            int b = 1;
            Console.WriteLine("Tam giac o giua");
            for (int i = 1; i <= rows; i++)
            {
                for (int space = rows; space > i; space--)
                {
                    Console.Write(" ");
                }
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(b + " ");
                    b++;
                }
                Console.WriteLine();
            }
        }
        //Cau 8: Write a program to display the n terms of harmonic series and their sum. 1 + 1/2 + 1/3 + 1/4 + 1/5 ... 1/n terms
        public static void Question_08()
        {
            Console.Write("Nhap n =");
            int n = int.Parse(Console.ReadLine());
            float s = 0.0f;
            Console.Write("Harmonic series:");
            for (int i = 1; i <=n; i++)
            {
                Console.Write("1/{0}", i);
                if (i<n)
                {
                    Console.Write(" + ");
                }
                s += 1.0f / i; //vi du: C += A tuong duong voi C = C + A, nghia la s = s + 1.0f/i
            }
            Console.WriteLine($"Tong la : {s}");
        }
    }
}


