using Assignment2.AbstractFactory.Interfaces;

namespace Assignment2.AbstractFactory
{
    internal class Dog : IAnimal
    {
        public Dog(string name)
        {
            Name = name;
            Type = "Dog";
        }

        public string Name { get; set; }
        public string Type { get; set; }
    }
}