using System.Collections.Generic;

namespace Assignment2.StateCommandMemento.Interfaces
{
    internal interface IMachine
    {
        IMachineState MachineState { get; set; }
        IPrinter Printer { get; set; }
        IMachineMemento CreateMemento();
        List<ICommand> CommandList { get; set; }
        void Compute(string command);
    }
}