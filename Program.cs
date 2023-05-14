using StudyCSharp.Homework;
using StudyCSharp.Homework.Morse;
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
            Morse morse = new Morse("Привет как дела?");
            Console.WriteLine(morse.CoderToMorse());
            Console.WriteLine(morse.MorseToText(".--. .-. .. .-- . - / -.- .- -.- / -.. . .-.. .-"));
        }
    }
}
