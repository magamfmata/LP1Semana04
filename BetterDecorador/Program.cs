using System;

    namespace BetterDecorador
    {

    }

    public class Program
    {
        private static string Decor(string s, char dec, int count)
        {
            return $"{dec}{dec}{dec} {s} {dec}{dec}{dec}";
        }
        private static void Main(string[] args)
        {
            if (args.Length==3);
            {
                string s = args[0];
                char c = char.Parse(args[1]);
                Console.WriteLine(Decor(s,c,int.Parse(args[2])));
            }
        }


    }