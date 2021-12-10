using System;

namespace Assignment2.Adapter
{
    internal class Adapter : IAdapter
    {
        public int ReturningStringsToInt(IReturningStrings c)
        {
            int number = 0;

            try
            {
                int.TryParse(c.ReturnString(), out number);
                return number;
            }
            catch
            {
                Console.WriteLine($"Failed to convert {c.ReturnString()}");
                return -1;
            }
        }
    }
}