using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyCSharp.Homework.Morse
{
    internal class Morse
    {
        private string text;

        public Morse(string text)
        {
            this.text = text;
        }

        public string CoderToMorse()
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
        public string MorseToText(string text)
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

            char[] delimeter = { ' ' };
            string[] words = text.Split(delimeter, StringSplitOptions.RemoveEmptyEntries);

            foreach (string item in words)
            {
                if (morseReversed.ContainsKey(item))
                {
                    morseBuilder.Append(morseReversed[item]);
                }
            }
            return morseBuilder.ToString().TrimEnd();
        }
    }
}
