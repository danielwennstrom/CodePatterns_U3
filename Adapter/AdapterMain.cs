namespace Assignment2.Adapter
{
    internal class AdapterMain
    {
        public void Run()
        {
            // Skriv en adapter för ReturningStrings som kan konsumeras av PrintingInts

            // ReturningStrings
            // PrintingInts

            // OBS TRASIG KOD - TA BORT NÄR DU BÖRJAR KODA
            // Det jag vill göra men inte kan är
            ReturningStrings returningStrings = new();
            PrintingInts printingInts = new();
            Adapter adapter = new();

            printingInts.Print(adapter.ReturningStringsToInt(returningStrings));
        }
    }
}