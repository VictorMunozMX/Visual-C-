using System;
using static System.Console;

namespace MakeWords
{
    class MakeWords
    {
        static void Main()
        {

            // vairables
            //read 1 word
            string firstWord = ReadWord("Front");
            //read 2 word
            string secondWord = ReadWord("Back");

            // together
            string newWord = MakeNewWord(firstWord, secondWord);

            // print on screen
            WriteLine();
            WriteLine("The word is {0}", newWord);
            ReadKey();

        }
        
        // methos to read words
        static string ReadWord(string wordPart) {
            WriteLine("Enter the part {0} of the word",wordPart);
            string s = ReadLine();
            return s;
        }

        // method to return resul with two variables
        static string MakeNewWord(string first, string last)
        {
            string w = first + last;
            return w;
        }

    }
}
