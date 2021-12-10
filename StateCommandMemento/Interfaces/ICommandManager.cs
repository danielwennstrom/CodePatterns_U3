namespace Assignment2.StateCommandMemento.Interfaces
{
    internal interface ICommandManager
    {
        IPrinter Printer { get; set; }
        void Execute(ICommand command);
    }
}