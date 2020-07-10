using System;
using System.Collections.Generic;

namespace Ch3Studio
{
    class Program
    {
        static void Main(string[] args)
        {
            string loremIpsum = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nunc accumsan sem ut ligula scelerisque sollicitudin. Ut at sagittis augue. Praesent quis rhoncus justo. Aliquam erat volutpat. Donec sit amet suscipit metus, non lobortis massa. Vestibulum augue ex, dapibus ac suscipit vel, volutpat eget massa. Donec nec velit non ligula efficitur luctus.";
            List<char> charList = new List<char>(loremIpsum);
            Dictionary<char, int> letterCounts = new Dictionary<char, int>();

            foreach (char c in charList)
            {
                if (!letterCounts.ContainsKey(c))
                {
                    letterCounts.Add(c, 1);
                }
                else if (letterCounts.ContainsKey(c))
                {
                    letterCounts[c]++;
                }
            }
            foreach (KeyValuePair<char, int> count in letterCounts)
            {
                Console.WriteLine(count.Key + ": " + count.Value);
            }
        }
    }
}
