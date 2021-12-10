using Assignment2.StateCommandMemento.Interfaces;

namespace Assignment2.StateCommandMemento
{
    internal class CommandManager : ICommandManager
    {
        public IPrinter Printer { get; set; }

        public CommandManager(IPrinter printer)
        {
            Printer = printer;
        }

        public void Execute(ICommand command)
        {
            command.Execute();
        }
    }
}