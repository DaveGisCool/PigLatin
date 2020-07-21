using System;

namespace PigLatin
{
    class Program
    {
        static void Main(string[] args)
        {
            bool keepLooping = true;

            Console.WriteLine("Welcome to the Pig Latin Translator!");
            Console.WriteLine();

            while (keepLooping)
            {
                Console.Write($"Enter a word to be translated: ");
                string userInput = Console.ReadLine();
                string prePL = userInput.ToLower();
                Console.WriteLine();
                char[] inputArray = prePL.ToCharArray();
                //char[] wordArray = new char[userInput.Length];

                Translate(inputArray);

                Console.WriteLine();
                Console.Write("Translate another line? (y/n)?  ");
                string userCont = Console.ReadLine();
                string cont = userCont.ToLower();
                if (cont == "n")
                {
                    keepLooping = false;
                }
                else if (cont != "y")
                {
                    Console.WriteLine("You have not selected y or y, exiting");
                    break;
                }
            }
            Console.WriteLine();
        }

        static void Translate(char[] inputArray)
        {
            int vowelIndex = 0;
            for (int index = 0; index < inputArray.Length; index++)
            {
                if (inputArray[index] == 'a' || inputArray[index] == 'e' || inputArray[index] == 'i' || inputArray[index] == 'o' || inputArray[index] == 'u' )
                {
                    string vowelPL = new string(inputArray);
                    vowelPL = vowelPL + "way";
                    Console.WriteLine();
                    Console.WriteLine(vowelPL);
                    Console.WriteLine();
                    break;
                }
                else
                {
                    for (int index2 = 0; index2 < inputArray.Length; index2++)
                    {
                        if (inputArray[index2] == 'a' || inputArray[index2] == 'e' || inputArray[index2] == 'i' || inputArray[index2] == 'o' || inputArray[index2] == 'u')
                        {
                            vowelIndex = index2;
                            break;
                        }
                    }
                    Console.WriteLine();
                    string consonantPL = new string(inputArray);
                    string vowelStart = consonantPL.Substring(vowelIndex);
                    string wordStart = consonantPL.Substring(0, vowelIndex);

                    Console.WriteLine($"{vowelStart}{wordStart}ay");
                    break;
                }
            }
        }
    }
}
