using System;
using System.Collections.Generic;

namespace MyGenerator
{
    public class Common
    {
        public void ProgramLoop()
        {
            Recognition("about");
            bool loop = true;
            while (loop)
            {
                string input = Input();
                loop = Recognition(input);
            }
        }

        public string Input()
        {
            Console.Write("> ");
            string input = Console.ReadLine();
            Console.WriteLine();

            return input;
        }

        public bool Recognition(string input)
        {
            switch (input)
            {
                case "a":
                case "about":
                    Console.WriteLine($"MyGenerator v. {Values.programVersion}.");
                    Console.WriteLine($"Last update - {Values.lastUpdate.ToString("yyyy/MM/dd")}.");
                    Console.WriteLine("Copyright under MIT license.");
                    Console.WriteLine("Source located at https://github.com/Sixaeity/MyGenerator.");
                    Console.WriteLine("For watching available commands type «list».\n");
                    return true;

                case "c":
                case "configure":
                    Parameters.ConfigureParameters();
                    return true;

                case "g":
                case "generate":
                    List<char> characters = Values.GenerateCharactersList(Parameters.includeNumbers, Parameters.includeUpperLetters, Parameters.includeLowerLetters, Parameters.includeSymbols);
                    List<char> randomizedCharacters = Values.RandomizeCharactersList(characters);
                    string output = Generator.Generate(Parameters.charactersAmount, randomizedCharacters);
                    Console.WriteLine($"Output: {output}\n");
                    return true;

                case "l":
                case "list":
                    List();
                    return true;

                case "q":
                case "quit":
                    return false;

                default:
                    Console.WriteLine("Unknown command.\n");
                    return true;
            }
        }

        public void List()
        {
            Console.WriteLine(" about, a - show application information.");
            Console.WriteLine(" configure, c - configure generator parameters.");
            Console.WriteLine(" generate, g - generate password.");
            Console.WriteLine(" list, l - show commands list.");
            Console.WriteLine(" quit, q - close program.\n");      
        }
    }
}