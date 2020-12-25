using System;
using System.Collections.Generic;

namespace MyGenerator
{
    public static class Generator
    {
        public static string Generate(int charactersAmount, List<char> characters)
        {
            string output = "";
            for (int i = 0; i < charactersAmount; i++)
            {
                Random random = new Random();
                int index = random.Next(characters.Count);
                output = output + Char.ToString(characters[index]);
            }
            
            return output;
        }
    }
}