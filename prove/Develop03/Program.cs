using System;

class Program
{
    static void Main(string[] args){
        
        Word word1 = new Word("For");
        Word word2 = new Word("God");
        Word word3 = new Word("so");
        Word word4 = new Word("loved");
        Word word5 = new Word("the");
        Word word6 = new Word("world");
        Word word7 = new Word("that");
        Word word8 = new Word("He");
        Word word9 = new Word("gave");
        Word word10 = new Word("His");
        Word word11 = new Word("only");
        Word word12 = new Word("Son");

        List<Word> wordsList = new List<Word> { word1, word2, word3, word4, word5, word6, word7, word8, word9, word10, word11, word12 };
        Reference reference = new Reference(3, 16);

        Scripture scripture = new Scripture(reference, wordsList);

        do
        {
            Console.Clear();
            scripture.Display();
            Console.WriteLine("Press Enter to hide a word or type 'quit' to end.");
            string userInput = Console.ReadLine();

            if (userInput.ToLower() == "quit")
            {
                break;
            }
            else
            {
                scripture.HideRandomWord();
            }

        } while (!scripture.AllWordsHidden());
    }

    
    }
