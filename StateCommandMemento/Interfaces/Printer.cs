using Assignment2.StateCommandMemento.Interfaces;
using System;

namespace Assignment2.StateCommandMemento
{
    internal class Printer : IPrinter
    {
        public void Print(string requestedString)
        {
            Console.WriteLine($"Printing {requestedString}");
        }
    }
}