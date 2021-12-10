using System;

namespace Assignment2.Facade
{
    internal class FacadeMain
    {
        public void Run()
        {
            // Write a facade to make it easier to save and load words
            WordFacade wordFacade = new();

            // Save Word
            string input = Console.ReadLine();
            if (input.Length != 5)
            {
                Console.WriteLine("Exiting program - Error - The string needs to be EXACTLY 5 characters long");
                Console.ReadKey(true);
            }
            else
            {
                wordFacade.Save(input);
            }

            // Load Word
            if (input.Length == 5)
            {
                Console.WriteLine(wordFacade.Load());
            }
        }
    }
}