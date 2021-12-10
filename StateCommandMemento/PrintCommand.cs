using Assignment2.StateCommandMemento.Interfaces;

namespace Assignment2.StateCommandMemento
{
    internal class PrintCommand : ICommand
    {
        private string _requestedString;
        private IPrinter _printer;

        public void Execute()
        {
            _printer.Print(_requestedString);
        }

        public PrintCommand(IPrinter printer, string requestedString)
        {
            _printer = printer;
            _requestedString = requestedString;
        }
    }
}