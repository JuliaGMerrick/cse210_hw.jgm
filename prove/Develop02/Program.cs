using System;

class Program
{
    static void Main(string[] args)
    {
        class Journal 
        {
            public void Run() 
            {
                DisplayIntro();

                DisplayOutro();
            }

            private void CreateJounalFile() {}

            private void DisplayIntro() 
            {
                ForegroundColor = ConsoleColor.Black;
                BackgroundColor = ConsoleColor.White;
                Clear();
                Console.WriteLine('Welcome to the journal app. ');
                Console.ReadKey(true);
            }
            
            private void DisplayOutro() 
            {
                Console.WriteLine('Thank you for using the journal app. ');
                Console.ReadKey(true);
            }

            private void DisplayJournalContents() {}

            private void AddEntry() {}
        }
            
    }
}