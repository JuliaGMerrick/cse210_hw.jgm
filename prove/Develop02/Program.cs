using System;

class Program
{
    static void Main(string[] args)
    {
        class Journal 
        {
            private string TitleArt = @"     ,..........   ..........,
     ,..,'          '.'          ',..,
    ,' ,'            :            ', ',
   ,' ,'             :             ', ',
  ,' ,'              :              ', ',
 ,' ,'............., : ,.............', ',
,'  '............   '.'   ............'  ',
 '''''''''''''''''';''';''''''''''''''''''
                    '''";

            public void Run() 
            {
                Title = ('Journal App');
                DisplayIntro();

                DisplayOutro();
            }

            private void CreateJounalFile() {}

            private void DisplayIntro() 
            {
                ForegroundColor = ConsoleColor.Black;
                BackgroundColor = ConsoleColor.White;
                Clear();
                Console.WriteLine(TitleArt);
                Console.WriteLine('\nWelcome to the journal app. ');
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