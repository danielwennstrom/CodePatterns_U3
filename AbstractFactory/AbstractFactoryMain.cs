using System;

namespace Assignment2.AbstractFactory
{
    internal class AbstractFactoryMain
    {
        // Skapa två fabriker som kan köra CreateAnimal() den ena fabriken ska skapa en hund och den andra en katt skapa sedan en abstract factory där man
        // får tillbaka en av de 2 fabrikerna beroende på en sträng parameter

        public void Run()
        {
            Factory factory = new Factory();

            var dog = factory.CreateAnimal("dog", "Lars-Olof");
            var cat = factory.CreateAnimal("cat", "Melvin");

            Console.WriteLine($"{dog.Name} -- {dog.Type}");
            Console.WriteLine($"{cat.Name} -- {cat.Type}");
        }
    }
}