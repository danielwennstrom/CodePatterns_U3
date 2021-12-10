using System;

namespace Assignment2.StateCommandMemento
{
    internal class MachineOffState : IMachineState
    {
        public void PowerSwitch()
        {
            Console.WriteLine("Power On");
        }
    }
}