using System;

namespace Assignment2.StateCommandMemento
{
    internal class SCMMain
    {
        /*
         * Skapa en maskin som kan vara av eller på. !Använd State Pattern!
         * Om man ger den ett kommando när den är av så ska den spara det kommandot och sen köra alla sparade kommandon när den sätts på. !Använd Command Pattern!
         * Kommandot ska vara att skriva ut en sträng text som användaren anger.
         * Det ska också finnas en reset funktion som tar bort alla sparade kommandon och stänger av maskinen. !Använd Memento Pattern!
         */

        public void Run()
        {
            Machine machine = new();
            var machineMemento = machine.CreateMemento();
            Console.WriteLine("Welcome!");
            Console.WriteLine("Power: power on/off.");
            Console.WriteLine("Reset: resets the machine.");
            Console.WriteLine("Anything else: prints a string. If the machine is off, the machine won't print anything until it is on.");
            Console.WriteLine("Please enter a command:");

            while (true)
            {
                var command = Console.ReadLine();

                switch (command.ToLower())
                {
                    case "power":
                        machine.PowerSwitch();
                        break;

                    case "reset":
                        machineMemento.Reset();
                        break;

                    default:
                        machine.Compute(command);
                        break;
                }
            }
        }
    }
}