using System;
using System.IO;
using System.Text.RegularExpressions;
namespace Challenge_2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"" + Console.ReadLine();
            while (!File.Exists(path))
            {
                Console.WriteLine("Enter another path");
                path = @"" + Console.ReadLine();
            }
            string text = File.ReadAllText(path);

            Console.Write("Enter word: ");
            string word = Console.ReadLine();

            Console.Write("Enter mode: ");
            int mode = Int32.Parse(Console.ReadLine());
            if (mode == 2)
            {
                Regex regex = new Regex($@"\W+{word}\W+", RegexOptions.IgnoreCase);
                MatchCollection math = regex.Matches(text);
                Console.WriteLine(math.Count.ToString());
            }
            else
            {
                Regex regex = new Regex(word, RegexOptions.IgnoreCase);
                MatchCollection math = regex.Matches(text);
                Console.WriteLine(math.Count.ToString());
            }
            Console.ReadKey();
        }
    }
}
