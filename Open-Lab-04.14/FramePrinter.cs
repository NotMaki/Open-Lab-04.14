using System;

namespace Open_Lab_04._14
{
    public class FramePrinter
    {
        public void Print(string[] strings)
        {
            int longest = 0;

            for (int i = 0; i < strings.Length; i++)
            {
                if (longest < strings[i].Length)
                {
                    longest = strings[i].Length;
                }
            }

            for (int j = 0; j < longest + 3; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine("*");

            for (int k = 0; k < strings.Length; k++)
            {
                Console.Write($"* {strings[k]}");

                for (int l = 0; l < longest - strings[k].Length; l++)
                {
                    Console.Write(" ");
                }
                Console.WriteLine(" *");
            }

            for (int i = 0; i < longest + 3; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine("*");
        }
    }
}
