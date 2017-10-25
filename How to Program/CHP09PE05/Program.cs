using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**
 * 9.5 (Sorting Letters and Removing Duplicates) 
 * Write a console app that inserts 30 random letters into a List< char >. 
 * Perform the following queries on the List and display your results: 
 * [Hint: Strings can be indexed like arrays to access a character at a specific index.] 
 * a) Use LINQ to sort the List in ascending order. 
 * b) Use LINQ to sort the List in descending order. 
 * c) Display the List in ascending order with duplicates removed.
 */ 
namespace CHP09PE05
{
    class SortLettersRemoveDuplicate
    {
        private const int SIZE = 30;
        private List<Char> list;

        public SortLettersRemoveDuplicate()
        {
            list = new List<Char>();
            FillList();
            RemoveDuplicates();
            SortAscendingOrder();
            SortDescendingOrder();
        }

        private void RemoveDuplicates()
        {
            list = list.Distinct().ToList();
            Console.WriteLine("List after removing distinct letters: ");
            DisplayList();
        }

        private void SortAscendingOrder()
        {
            var ascList = list.OrderBy(c => c);

            Console.WriteLine("List after sorting in ascending order");

            DisplayList(ascList);
        }

        private void SortDescendingOrder()
        {
            var descList = list.OrderByDescending(c => c);

            Console.WriteLine("List after sorting in descending order");

            DisplayList(descList);            
        }

        private void FillList()
        {
            Random rand = new Random();

            for (int i = 0; i < SIZE; i++)
                list.Add((char)(rand.Next(26) + 97));

            Console.WriteLine("List after being filled: ");
            DisplayList();
        }

        private void DisplayList()
        {
            foreach (char c in list)
                Console.Write(c + " ");

            Console.WriteLine();
        }

        private void DisplayList(IOrderedEnumerable<Char> list)
        {
            foreach (char c in list)
                Console.Write(c + " ");

            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            SortLettersRemoveDuplicate obj = new SortLettersRemoveDuplicate();
        }
    }
}
