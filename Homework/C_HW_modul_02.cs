using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace StudyCSharp.Homework
{
    internal class C_HW_modul_02T1
    {
        private const int SIZE = 5;
        private const int ROWCOUNT = 3;
        private const int COLUMCOUNT = 4;
        private int[] arrayA;
        private double[,] arrayB;

        public C_HW_modul_02T1()
        {
            arrayA = new int[SIZE];
            arrayB = new double[ROWCOUNT, COLUMCOUNT];
        }

        public void InitArrayA()
        {
            int count = 0, value = 0;
            while (count != SIZE)
            {
                Console.WriteLine("Введите значение элемета: ");
                value = Convert.ToInt32(Console.ReadLine());
                arrayA[count] = value;
                count++;
            }
        }
        public void GenerateValueArrayB()
        {
            Random rnd = new Random();
            for (int i = 0; i < ROWCOUNT; i++)
            {
                for (int j = 0; j < COLUMCOUNT; j++)
                {
                    arrayB[i, j] = rnd.Next(0, 100);
                }
            }
        }
        public void DrawArrayA()
        {
            for (int i = 0; i < SIZE; i++)
            {
                Console.Write($"{arrayA[i]} ");
            }
            Console.WriteLine();
        }
        public void DrawArrayB()
        {
            for (int i = 0; i < ROWCOUNT; i++)
            {
                for (int j = 0; j < COLUMCOUNT; j++)
                {
                    Console.Write($"{arrayB[i, j]} ");
                }
                Console.WriteLine();
            }
        }

        public void SearchCommonMaxElement()
        {
            int maxElementArrayA = arrayA[0];
            double maxElementArrayB = arrayB[0, 0];

            while (true)
            {

                for (int i = 0; i < SIZE; i++)
                {
                    if (maxElementArrayA < arrayA[i])
                    {
                        maxElementArrayA = arrayA[i];
                    }
                }
                for (int i = 0; i < ROWCOUNT; i++)
                {
                    for (int j = 0; j < COLUMCOUNT; j++)
                    {
                        if (maxElementArrayB > arrayB[i, j])
                        {
                            maxElementArrayB = arrayB[i, j];
                        }
                    }
                }
                if (maxElementArrayA == maxElementArrayB)
                {
                    Console.Write($"Общий максимальный элемент найден. {maxElementArrayA}");
                    break;
                }
                else
                {
                    Console.Write($"Общий максимальный элемент не найден");
                    break;
                }
            }
        }

        public void SearchCommonMinElement()
        {
            int minElementArrayA = arrayA[0];
            double minElementArrayB = arrayB[0, 0];

            while (true)
            {

                for (int i = 0; i < SIZE; i++)
                {
                    if (minElementArrayA > arrayA[i])
                    {
                        minElementArrayA = arrayA[i];
                    }
                }
                for (int i = 0; i < ROWCOUNT; i++)
                {
                    for (int j = 0; j < COLUMCOUNT; j++)
                    {
                        if (minElementArrayB > arrayB[i, j])
                        {
                            minElementArrayB = arrayB[i, j];
                        }
                    }
                }
                if (minElementArrayA == minElementArrayB)
                {
                    Console.Write($"Общий минимальный элемент найден. {minElementArrayA}");
                    break;
                }
                else
                {
                    Console.Write($"Общий минимальный элемент не найден");
                    break;
                }
            }
        }

        public void CommonSum()
        {
            double result = 0;

            for (int i = 0; i < SIZE; i++)
            {
                result += arrayA[i];
            }
            for (int i = 0; i < ROWCOUNT; i++)
            {
                for (int j = 0; j < COLUMCOUNT; j++)
                {
                    result += arrayB[i, j];
                }
            }
            Console.Write($"Общая сумма элеентов {result}");
        }
        public void CommonMult()
        {
            double result = 1;

            for (int i = 0; i < SIZE; i++)
            {
                result *= arrayA[i];
            }
            for (int i = 0; i < ROWCOUNT; i++)
            {
                for (int j = 0; j < COLUMCOUNT; j++)
                {
                    result *= arrayB[i, j];
                }
            }
            Console.Write($"Общая сумма элеентов {result}");
        }
        public void SumEvenElementArrayA()
        {
            int result = 0;

            for (int i = 0; i < SIZE; i++)
            {
                if (arrayA[i] % 2 == 0)
                {
                    result += arrayA[i];
                }
            }
        }
        public void SumOddElementArrayB()
        {
            double result = 0;
            for (int i = 0; i < ROWCOUNT; i++)
            {
                for (int j = 0; j < COLUMCOUNT; j += 2)
                {
                    result += arrayB[i, j];
                }
            }
        }
    }
    internal class C_HW_modul_02T2
    {
        private const int ROWCOUNT = 5;
        private const int COLUMCOUNT = 5;
        private int[,] array;

        public C_HW_modul_02T2()
        {
            array = new int[ROWCOUNT, COLUMCOUNT];
        }

        public void GenerateValueArray()
        {
            Random rnd = new Random();
            for (int i = 0; i < ROWCOUNT; i++)
            {
                for (int j = 0; j < COLUMCOUNT; j++)
                {
                    array[i, j] = rnd.Next(-100, 100);
                }
            }
        }
        public void SearchSumElement()
        {
            int minElement = array[0, 0], maxElement = array[0, 0];

            int indexMinI = 0, indexMaxI = 0, indexMinJ = 0, indexMaxJ = 0;

            for (int i = 0; i < ROWCOUNT; i++)
            {
                for (int j = 0; j < COLUMCOUNT; j++)
                {
                    if (array[i, j] < minElement)
                    {
                        minElement = array[i, j];
                        indexMinI = i;
                        indexMinJ = j;
                    }
                    if (array[i, j] > maxElement)
                    {
                        maxElement = array[i, j];
                        indexMaxI = i;
                        indexMaxJ = j;
                    }
                }
            }
            int result = 0;
            int startIndexI = Math.Min(indexMinI, indexMaxI) + 1;
            int endIndexI = Math.Max(indexMinI, indexMaxI);
            int startIndexJ = Math.Min(indexMinJ, indexMaxJ) + 1;
            int endIndexJ = Math.Max(indexMinJ, indexMaxJ);

            for (int i = startIndexI; i < endIndexI; i++)
            {
                for (int j = startIndexJ; j < endIndexJ; j++)
                {
                    result += array[i, j];
                }
            }
        }
    }
    internal class C_HW_modul_02T3
    {
        private string text;

        public void inputText()
        {
            Console.WriteLine("Введите желаемый текст.");
            text = Console.ReadLine();
        }

        public void Uppercase()
        {
            if (string.IsNullOrEmpty(text))
            {
                throw new ArgumentNullException("Текст не был введен");
            }

            char[] delimeter = { '.', '!', '?' };
            string[] words = text.Split(delimeter, StringSplitOptions.RemoveEmptyEntries);

            string outPutText = "";
            for (int wordIndex = 0; wordIndex < words.Length; wordIndex++)
            {
                string currentWord = words[wordIndex];
                if (currentWord.Length > 0)
                {
                    char firstChar = currentWord[0];
                    outPutText += char.ToUpper(firstChar) + currentWord.Substring(1);
                }

                if (wordIndex < words.Length - 1)
                {
                    char delimeterChar = text[text.IndexOf(currentWord) + currentWord.Length];
                    outPutText += delimeterChar;
                }
            }

            foreach (char word in outPutText)
            {
                Console.Write(word);
            }
        }
    }
    internal class C_HW_modul_02T4
    {
        private string text;

        public void inputText()
        {
            Console.WriteLine("Введите желаемый текст.");
            text = Console.ReadLine();
        }

        public void CensorText()
        {
            if (string.IsNullOrEmpty(text))
            {
                throw new ArgumentNullException("Текст не был введен");
            }

            char[] delimiterChars = { ' ', ',', '.', ':', '\t' };
            string tmp = "";

            string[] censorWord = new string[] { "fuck", "shit", "crap", "fucked", "noob", "damn", "fool" };

            string[] words = text.Split(delimiterChars);
            Console.WriteLine($"{words.Length} words in text:");

            for (int i = 0; i < words.Length; i++)
            {
                for (int j = 0; j < censorWord.Length; j++)
                {
                    if (words[i] == censorWord[j])
                    {
                        int count = words[i].Length;
                        for (int k = 0; k < count; k++)
                        {
                            tmp += "*";
                        }
                        words[i] = tmp;
                        tmp = "";
                    }
                }
            }

            foreach (var word in words)
            {
                System.Console.WriteLine($"{word}");
            }
        }
    }
}
