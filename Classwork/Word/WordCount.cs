using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyCSharp.Classwork
{
    internal class WordCount
    {
        public void CountWordText(string text)
        {
            char[] separator = { ' ', ',', '.', ':', '!', '?', '\n' };
            string[] words = text.Split(separator, StringSplitOptions.RemoveEmptyEntries);

            Console.Write($"Количество слов в тексте: {words.Length}");
        }

        public void CountRepeatWordInTextToDictionary()
        {
            Dictionary<string, int> keyValuePairs = new Dictionary<string, int>();

            string text = "Привет, это первый текст. Привет, это второй текст. Привет, это третий текст, а также ЭтО четвертный ТЕКСТ";
            char[] separators = new char[] { ' ', '.', ',' };

            string[] words = text.Split(separators, StringSplitOptions.RemoveEmptyEntries);


            foreach (var item in words)
            {
                string lowercaseWord = item.ToLower();
                if (!keyValuePairs.ContainsKey(lowercaseWord))
                {
                    keyValuePairs.Add(lowercaseWord, 1);
                }
                else
                {
                    keyValuePairs[lowercaseWord]++;
                }
            }

            foreach (var item in keyValuePairs)
            {
                Console.WriteLine($"{item.Key} : {item.Value}");
            }
        }
    }
}
