using System;
using System.Collections.Generic;

namespace MyGenerator
{
    public static class Values
    {
        // Program constants.
        public const string programVersion = "Beta-1.0"; 
        public readonly static DateTime lastUpdate = new DateTime(2021, 01, 03);

        // Characters used in generation.
        public static List<char> characters = new List<char> {};

        // All characters lists.
        public readonly static List<char> numbers = new List<char> {'0', '1', '2', '3', '4', '5', '6', '7', '8', '9'};
        public readonly static List<char> upperLetters = new List<char> {'A', 'B', 'C', 'D', 'E', 'F', 'G',
                                                                         'H', 'I', 'J', 'K', 'L', 'M', 'N',
                                                                         'O', 'P', 'Q', 'R', 'S', 'T', 'U',
                                                                         'V', 'W', 'X', 'Y', 'Z'};
        public readonly static List<char> lowerLetters = new List<char> {'a', 'b', 'c', 'd', 'e', 'f', 'g',
                                                                         'h', 'i', 'j', 'k', 'l', 'm', 'n',
                                                                         'o', 'p', 'q', 'r', 's', 't', 'u',
                                                                         'v', 'w', 'x', 'y', 'z'};
        public readonly static List<char> symbols = new List<char> {'!', '@', '#', '$', '%', '^', '&', '*', '+', '=', '-', ';', ':',
                                                                    '(', ')', '[', ']', '{', '}', '<', '>', '|', '/',
                                                                    '"', '\'', '`', '?', ',', '.', '_', '~'};

        // Add all included lists to one list.
        public static List<char> GenerateCharactersList(bool includeNumbers, bool includeUpperLetters, bool includeLowerLetters, bool includeSymbols)
        {
            if (includeNumbers)
            {
                foreach (char number in numbers)
                {
                    characters.Add(number);
                }
            }

            if (includeUpperLetters)
            {
                foreach (char upperLetter in upperLetters)
                {
                    characters.Add(upperLetter);
                }
            }

            if (includeLowerLetters)
            {
                foreach (char lowerLetter in lowerLetters)
                {
                    characters.Add(lowerLetter);
                }
            }

            if (includeSymbols)
            {
                foreach (char symbol in symbols)
                {
                    characters.Add(symbol);
                }
            }

            return characters;
        }

        // Randomize order of characters in list.
        public static List<char> RandomizeCharactersList(List<char> characters)
        {
            // Generates indexes.
            List<int> indexes = new List<int> {}; 
            for (int i = 0; i < characters.Count;)
            {
                Random random = new Random();
                int index = random.Next(characters.Count);
                if (!indexes.Contains(index))
                {
                    indexes.Add(index);
                    i++;
                }
            }

            // Adds characters to new list in random order by indexes.
            List<char> randomizedCharacters = new List<char> {};
            foreach (char index in indexes)
            {
                randomizedCharacters.Add(characters[index]);
            }

            return randomizedCharacters;
        }
    }
}