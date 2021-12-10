using Assignment2.StateCommandMemento.Interfaces;
using System.Collections.Generic;

namespace Assignment2.StateCommandMemento
{
    internal class Machine : IMachine
    {
        public IMachineState MachineState { get; set; }
        public IPrinter Printer { get; set; }
        public ICommandManager CommandManager { get; set; }
        public List<ICommand> CommandList { get; set; }

        public Machine()
        {
            MachineState = new MachineOffState();
            CommandList = new();
            Printer = new Printer();
            CommandManager = new CommandManager(Printer);
        }

        public void PowerSwitch()
        {
            MachineState.PowerSwitch();

            if (MachineState is MachineOffState)
            {
                if (CommandList.Count > 0)
                {
                    foreach (var c in CommandList)
                    {
                        CommandManager.Execute(c);
                    }

                    CommandList = new();
                }
                MachineState = new MachineOnState();
            }
            else
            {
                MachineState = new MachineOffState();
            }
        }

        public void Compute(string requestedString)
        {
            var printCommand = new PrintCommand(Printer, requestedString);

            if (MachineState is MachineOffState)
            {
                CommandList.Add(printCommand);
            }
            else
            {
                CommandManager.Execute(printCommand);
            }
        }

        public IMachineMemento CreateMemento()
        {
            return new MachineMemento(this);
        }
    }
}