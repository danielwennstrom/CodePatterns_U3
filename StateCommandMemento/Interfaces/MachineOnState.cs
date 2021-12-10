using System;

namespace Assignment2.StateCommandMemento
{
    internal class MachineOnState : IMachineState
    {
        public void PowerSwitch()
        {
            Console.WriteLine("Power Off");
        }
    }
}