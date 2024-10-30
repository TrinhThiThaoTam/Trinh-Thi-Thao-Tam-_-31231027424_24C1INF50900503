using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trinh_Thi_Thao_Tam___31231027424_24C1INF50900503
{
    internal class session_05
    {
        public static void swap (ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }
    public static void Main5(string[] args)
        {
            int a = 6, b= 7;
            Console.WriteLine($"Before call a = {a}, b = {b}");
            swap (ref a, ref b);
            Console.WriteLine($"After call a = {a}, b = {b}");
            Console.ReadKey();
        }
    }
    class Game_TaiXiu
    {
        static int RollDice()
        {
            Random rnd = new Random();
            int die_1 = rnd.Next(6) + 1;
            int die_2 = rnd.Next(6) + 1;
            int die_3 = rnd.Next(6) + 1;
            int sum_of_dice = die_1 + die_2 + die_3;
            return sum_of_dice;
        }
        static void PlayOneRound()
        {

        }
    }
}
            
﻿