using System.Collections.Generic;

namespace Assignment2.StateCommandMemento.Interfaces
{
    internal class MachineMemento : IMachineMemento
    {
        public IMachine Machine { get; set; }
        public IMachineState MachineState { get; set; }
        public ICommandManager CommandManager { get; set; }
        public List<ICommand> CommandList { get; set; }

        public MachineMemento(IMachine machine)
        {
            Machine = machine;
            MachineState = new MachineOffState();
            CommandManager = new CommandManager(machine.Printer);
            CommandList = new();
        }

        public void Reset()
        {
            Machine.MachineState = MachineState;
            Machine.CommandList = new();
        }
    }
}