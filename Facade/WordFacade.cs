using System.Collections.Generic;

namespace Assignment2.Facade
{
    internal class WordFacade
    {
        // https://youtu.be/U1UtRnGn5hc
        private List<List<char>> CharLists;

        public WordFacade()
        {
            CharLists = new();
        }

        public void Save(string input)
        {
            foreach (char c in input)
            {
                CharLists.Add(new List<char>() { c });
            }
        }

        public char[] Load()
        {
            char[] word = new char[CharLists.Count];
            CharLists.ForEach(x => word[CharLists.IndexOf(x)] = x[0]);

            return word;
        }
    }
}