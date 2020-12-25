using System;

namespace MyGenerator
{
    public class Parameters
    {
        // Default is 16.
        public static int charactersAmount = 16;

        // Default all is true.
        public static bool includeNumbers = true;
        public static bool includeUpperLetters = true;
        public static bool includeLowerLetters = true;
        public static bool includeSymbols = true;

        public static void ConfigureParameters()
        {
            Console.WriteLine(" Include numbers? (y/n)");
            includeNumbers = UserAnswer();

            Console.WriteLine(" Include uppercase letters? (y/n)");
            includeUpperLetters = UserAnswer();

            Console.WriteLine(" Include lowercase letters? (y/n)");
            includeLowerLetters = UserAnswer();

            Console.WriteLine(" Include symbols? (y/n)");
            includeSymbols = UserAnswer();

            Console.WriteLine();
        }

        public static bool UserAnswer()
        {
            Console.Write(" - ");
            string input = Console.ReadLine();
            switch (input)
            {
                case "y":
                case "yes":
                    return true;

                case "n":
                case "no":
                    return false;

                default:
                    Console.WriteLine("\tUnknown option. Using value by default.\n");
                    return true;
            }
        }
    }
}