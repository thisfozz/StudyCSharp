﻿using StudyCSharp.Homework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace StudyCSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(MorzeToText("- . ... -"));
        }
        static string CoderMorse(string text)
        {

            Dictionary<char, string> morseAlphabet = new Dictionary<char, string>()
            {
                {'А', ".-" },
                {'Б', "-..." },
                {'В', ".--" },
                {'Г', "--." },
                {'Д', "-.." },
                {'Е', "." },
                {'Ж', "...-" },
                {'З', "--.." },
                {'И', ".." },
                {'Й', ".---" },
                {'К', "-.-" },
                {'Л', ".-.." },
                {'М', "--" },
                {'Н', "-." },
                {'О', "---" },
                {'П', ".--." },
                {'Р', ".-." },
                {'С', "..." },
                {'Т', "-" },
                {'У', "..-" },
                {'Ф', "..-." },
                {'Х', "...." },
                {'Ц', "-.-." },
                {'Ч', "---." },
                {'Ш', "----" },
                {'Щ', "--.-" },
                {'Ъ', "--.--" },
                {'Ы', "-.--" },
                {'Ь', "-..-" },
                {'Э', "..-.." },
                {'Ю', "..--" },
                {'Я', ".-.-" },
                {' ', "/"}
            };

            StringBuilder morseBuilder = new StringBuilder();

            foreach (char item in text.ToUpper())
            {
                if (morseAlphabet.ContainsKey(item))
                {
                    morseBuilder.Append(morseAlphabet[item] + " ");
                }
            }

            return morseBuilder.ToString().TrimEnd();
        }
        static string MorzeToText(string text)
        {

            Dictionary<string, char> morseReversed = new Dictionary<string, char>()
            {
                {".-", 'А'},
                {"-...", 'Б'},
                {".--", 'В'},
                {"--.", 'Г'},
                {"-..", 'Д'},
                {".", 'Е'},
                {"...-", 'Ж'},
                {"--..", 'З'},
                {"..", 'И'},
                {".---", 'Й'},
                {"-.-", 'К'},
                {".-..", 'Л'},
                {"--", 'М'},
                {"-.", 'Н'},
                {"---", 'О'},
                {".--.", 'П'},
                {".-.", 'Р'},
                {"...", 'С'},
                {"-", 'Т'},
                {"..-", 'У'},
                {"..-.", 'Ф'},
                {"....", 'Х'},
                {"-.-.", 'Ц'},
                {"---.", 'Ч'},
                {"----", 'Ш'},
                {"--.-", 'Щ'},
                {"--.--", 'Ъ'},
                {"-.--", 'Ы'},
                {"-..-", 'Ь'},
                {"..-..", 'Э'},
                {"..--", 'Ю'},
                {".-.-", 'Я'},
                {"/", ' '}
            };

            StringBuilder morseBuilder = new StringBuilder();

            char[] delimeter = { ' ', '/' };
            string[] words = text.Split(delimeter, StringSplitOptions.RemoveEmptyEntries);

            foreach (string item in words)
            {
                if (morseReversed.ContainsKey(item))
                {
                    morseBuilder.Append(morseReversed[item] + "");
                }
            }
            return morseBuilder.ToString().TrimEnd();
        }
    }
}
