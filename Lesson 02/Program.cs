﻿using System;

namespace Lesson_02
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1.
            //Console.WriteLine("Write text");
            //string text = Console.ReadLine();
            //Console.WriteLine("Your text was following - " + text);

            // 2.
            Console.WriteLine("Write text");
            string text = Console.ReadLine();
            int length = text.Length;
            Console.WriteLine("Your text was length - " + length);


        }
    }
}
