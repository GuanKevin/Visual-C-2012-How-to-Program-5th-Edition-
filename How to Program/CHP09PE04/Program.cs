using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**
 * 9.4 (Duplicate Word Removal) 
 * Write a console app that inputs a sentence from the user (assume no punctuation), 
 * then determines and displays the nonduplicate words in alphabetical order. 
 * Treat uppercase and lowercase letters the same. [Hint: You can use string method Split with no arguments, 
 * as in sentence.Split(), to break a sentence into an array of strings containing the individual words. 
 * By default, Split uses spaces as delimiters. Use string method ToLower in the select and orderby 
 * clauses of your LINQ query to obtain the lowercase version of each word.]
 */
namespace CHP09PE04
{
    class DuplicateRemoval
    {
        private List<String> vanillaList;
        private List<String> nonDuplicateList;

        /**
         * Constructor to initialize the program
         */ 
        public DuplicateRemoval()
        {
            DisplayMessage();
        }

        /**
         * Request user to input a sentence
         * Split sentence to words by white space deliminator
         * Stores words in list
         */ 
        private void DisplayMessage()
        {
            Console.Write("Enter a sentence: ");
            string sentence = Console.ReadLine();
            vanillaList = new List<String>(sentence.Split());
            nonDuplicateList = vanillaList.ConvertAll(words => words.ToLower());
            nonDuplicateList = nonDuplicateList.Distinct().ToList();

            foreach (String word in nonDuplicateList)
            {
                Console.WriteLine(word);
            }
        }

        /**
         * Program's entry point
         */ 
        public static void Main(String[] args)
        {
            DuplicateRemoval dup = new DuplicateRemoval();
        }
    }
}
