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
    }
}
