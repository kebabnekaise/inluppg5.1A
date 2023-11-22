using System;

namespace inluppg5_2A
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] ord = new string[] { "Hej", "på", "dig", "din", "filur" };
            for (int i = 0; i < ord.Length; i++)
            {
                Console.WriteLine(ord[i]);
                Console.WriteLine();
            }
        }
    }
}