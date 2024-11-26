using System;
using System.Collections.Generic;
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
        private static void Main()
        {
            string s = "Verbatim string literals are more convenient for multi-line strings";
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
        }
    }
}
