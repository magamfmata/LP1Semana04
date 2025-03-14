using System;

    namespace BetterDecorador
    {

    }

    public class Program
    {
        /// <summary>
        /// decorates a string 
        /// takes 3 arguments and converts them into a string
        /// multiplies the char
        /// </summary>
        /// <param name="s">string that is being decorated</param>
        /// <param name="dec">char that is decorating the string</param>
        /// <param name="count">multiplies the char</param>
        /// <returns>string that is decorated</returns>
        private static string Decor(string s, char dec, int count)
        {
            return $"{dec}{dec}{dec} {s} {dec}{dec}{dec}";
        }
        /// <summary>
        /// method that receives parameters and shows decorated string
        /// checks if the correct argument numbers was made
        /// converts it to the desired type
        /// </summary>
        /// <param name="args"></param>
        private static void Main(string[] args)
        {
            if (args.Length==3);
            {
                string s = args[0];
                char c = char.Parse(args[1]);
                Console.WriteLine(Decor(s,c,int.Parse(args[2])));
            }
            /// <summary>
            /// this method uses Decor method 
            /// it prints ("User did not specify args!", '=', 3)
            /// </summary>
            /// <returns></returns>
             private static string Decor()
        {
            return Decor("User did not specify args!", '=', 3);
        }

        }


    }