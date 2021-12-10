namespace Assignment2.AbstractFactory.Interfaces
{
    internal interface IFactory
    {
        IAnimal CreateAnimal(string type, string name);
    }
}