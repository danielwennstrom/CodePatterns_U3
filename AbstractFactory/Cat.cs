using Assignment2.AbstractFactory.Interfaces;

namespace Assignment2.AbstractFactory
{
    internal class Cat : IAnimal
    {
        public Cat(string name)
        {
            Name = name;
            Type = "Cat";
        }

        public string Name { get; set; }
        public string Type { get; set; }
    }
}