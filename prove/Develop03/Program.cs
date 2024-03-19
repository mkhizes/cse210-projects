using System;

class Program
{
    static void Main(string[] args){
        
        Word word1 = new Word("Trust");
        Word word2 = new Word("in");
        Word word3 = new Word("the");
        Word word4 = new Word("Lord");
        Word word5 = new Word("with");
        Word word6 = new Word("all");
        Word word7 = new Word("thine");
        Word word8 = new Word("Heart");
        Word word9 = new Word("and");
        Word word10 = new Word("lean");
        Word word11 = new Word("not");
        Word word12 = new Word("unto");
        Word word13 = new Word("thine");
        Word word14 = new Word("own");
        Word word15 = new Word("understanding.");
        Word word16 = new Word("In");
        Word word17 = new Word("all");
        Word word18 = new Word("thy");
        Word word19 = new Word("ways");
        Word word20 = new Word("acknowledge");
        Word word21 = new Word("Him,");
        Word word22 = new Word("and");
        Word word23 = new Word("He");
        Word word24 = new Word("shall");
        Word word25 = new Word("owndirect");
        Word word26 = new Word("thy");
        Word word27 = new Word("paths");

        List<Word> wordsList = new List<Word> { word1, word2, word3, word4, word5, word6, word7, word8, word9, word10, word11, word12,word13,word14,word15,word16, word17, word18, word19, word20, word21, word22, word23, word24,word25,word26,word27 };
        Reference reference = new Reference(3, 5-6);

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
