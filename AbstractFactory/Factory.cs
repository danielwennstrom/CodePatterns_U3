using Assignment2.AbstractFactory.Interfaces;

namespace Assignment2.AbstractFactory
{
    internal class Factory : IFactory
    {
        public Dog CreateDog(string name)
        {
            return new Dog(name);
        }

        public Cat CreateCat(string name)
        {
            return new Cat(name);
        }

        public IAnimal CreateAnimal(string type, string name)
        {
            if (type.ToLower() == "dog")
            {
                return CreateDog(name);
            }
            else if (type.ToLower() == "cat")
            {
                return CreateCat(name);
            }
            return null;
        }
    }
}