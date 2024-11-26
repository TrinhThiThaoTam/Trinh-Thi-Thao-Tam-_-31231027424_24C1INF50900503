using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trinh_Thi_Thao_Tam___31231027424_24C1INF50900503
{
    internal class session_08
    {
        static void lenOfString(string s)
        {
            int len = 0;
            foreach (char c in s)
                len++;
            Console.WriteLine($"Do dai cua chuoi la: {len}");
        }
        static void seperateCharacter(string s)
        {
            foreach (char c in s)
                Console.WriteLine(c);
        }
        static void reverseOrder(string s)
        {
            Console.WriteLine($"individual characters of the string in reverse order is: ");
            for (int i = s.Length - 1; i>= 0;  i--)
            {
                Console.Write(s[i]);
            }
            Console.WriteLine();
        }
        static int totalNumbersOfWord(string s)
        {
            int count = 0;
            s = s.Trim(); //bo khoang trang dau va cuoi cua chuoi
            while (s.IndexOf("  ") != -1)
                s = s.Replace("  ", " ");
            //dem
            foreach (char c in s)
                if (c == ' ') count++;
            return count + 1;
        }
        static int compareTwoStrings(string s1, string s2)
        {
            //tra ve 0 neu s1==s2, tra ve 1 neu s1>s2, tra ve -1 neu s1<s2
            int min_len =s1.Length < s2.Length ? s1.Length : s2.Length;
            for (int i = 0; i < min_len; i++)
            {
                if (s1[i] > s2[i]) return 1;
                if (s1[i] < s2[i]) return -1;
            }
            return s1.Length > s2.Length ? 1 : s1.Length < s2.Length ? -1 : 0;  
        }
        static void countNumbersofAlphaDigitSpecial(string s)
        {
            int so = 0;
            int chu = 0;
            int speical = 0;
            foreach (char c in s)
            {
                if ((c > 'a' && c < 'z') || (c > 'A' && c < 'Z'))
                    chu++;
                else if (c >= '0' && c <= '9')
                    so++;
                else 
                    speical++;
            }
            Console.Write($"Co {chu} chu cai, {so} so và {speical} ky tu khac trong chuoi");
            Console.WriteLine();
        }
        static void countVowelsandConsonants(string s)
        {
            int vowel = 0;
            int consonant = 0;
            foreach (char c in s)
            {
                if ((c == 'u') || (c == 'e') || (c == 'o') || (c == 'a') || (c == 'i') || (c == 'U') || (c == 'E') || (c == 'O') || (c == 'A') || (c == 'I'))
                    vowel++;
                else consonant++;
            }
            Console.Write($"Co {vowel} nguyen am va {consonant} phu am trong chuoi");
            Console.WriteLine();
        }
        static void subStringPresent(string s, string ss)
        {
            if (s.Contains(ss))
            {
                Console.WriteLine("Ton tai chuoi con trong chuoi");
            }    
            else
            {
                Console.WriteLine("Khong ton tai chuoi con trong chuoi");
            }
        }
        static void searchPositionOfString(string s, string ss)
        {
            int pos = s.IndexOf(ss);
            if (pos != -1) // index of se tra ve vi tri dau tien cua substring trong chuoi, neu khong tim duoc chuoi con se tra gia tri ve -1
            {
                Console.WriteLine($"Chuoi con nam o vi tri {pos}"); // neu chuoi con nam o dau tien thi tra ve gia tri 0
            }    
            else
            {
                Console.WriteLine($"Chuoi con khong ton tai trong chuoi");
            }
        }
        static bool isAlphabet(string s)
        {
            foreach (char c in s)
            {
                if ((c >= 'A' && c <= 'Z') || (c >= 'a' && c <= 'z'))
                {
                    Console.WriteLine($"Ky tu {c} la chu cai");
                    return true;
                }
            }
            return false;
        }
        private static void Main()
        {
            string s = "Verbatim string literals are more convenient for multi-line strings 5";
            Console.WriteLine(s);
            lenOfString(s);
            seperateCharacter(s);
            reverseOrder(s);
            int wordcount = totalNumbersOfWord(s);
            Console.WriteLine($"So tu la: {wordcount}");
            totalNumbersOfWord(s);
            string s1 = "hella";
            string s2 = "hello";
            compareTwoStrings(s1, s2);
            Console.WriteLine(s1.CompareTo(s2));
            countNumbersofAlphaDigitSpecial(s);
            countVowelsandConsonants(s);
            Console.Write("Nhap chuoi con: ");
            string ss = Console.ReadLine();
            subStringPresent(s, ss);
            searchPositionOfString(s, ss);
            isAlphabet(s);
        }
    }
}
