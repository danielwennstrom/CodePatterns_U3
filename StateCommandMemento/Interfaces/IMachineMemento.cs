using Assignment2.StateCommandMemento.Interfaces;
using System.Collections.Generic;

namespace Assignment2.StateCommandMemento
{
    internal interface IMachineMemento
    {
        IMachine Machine { get; set; }
        IMachineState MachineState { get; set; }
        ICommandManager CommandManager { get; set; }
        List<ICommand> CommandList { get; set; }
        void Reset();
    }
}