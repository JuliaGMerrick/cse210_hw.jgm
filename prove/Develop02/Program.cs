using System;

class Program
{
    static void Main(string[] args)
    {
        class Journal 
        {
            DateTime theCurrentTime = DateTime.Now;
            string dateText = theCurrentTime.ToShortDateString();
            private string journalFile = 'journal.txt'
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
                CreateJounalFile();
                RunMenu();
                DisplayOutro();
            }

            private void RunMenu()
            {
                string choice; 
                
                do
                {
                    choice = GetChoice();
                    switch(choice)
                    {
                        case '1':
                            AddEntry();
                            break;
                        case '2':
                            DisplayJournalContents();
                            break;
                        case '3':
                            SaveEntry();
                            break;
                        default:
                            break;
                    }
                }while (choice != '4');
            }

            private string GetChoice()
            {
                bool isChoiceValid = false;
                string choice = '';

                do
                {
                    Clear();
                    BackgroundColor = Console.DarkGrey
                    Console.WriteLine(TitleArt);
                    ForegroundColor = ConsoleColor.Black;
                    BackgroundColor = ConsoleColor.White;
                    Console.WriteLine('\nWhat would you like to do?')
                    Console.WriteLine(' >1 - Write New Entry')
                    Console.WriteLine(' >2 - Read Previous Entries')
                    Console.WriteLine(' >3 - Save Entries')
                    Console.WriteLine(' >4 - Quit')

                    choice = ReadLine().Trim();
                    if (choice = 1 || choice = 2 || choice = 3 || choice = 4)
                    {
                        isChoiceValid = true;
                        WaitForKey();
                    }
                    else
                    {
                        ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine($'{choice} is not valid.')
                        WaitForKey();
                    }
                    return choice;
                }while(!isChoiceValid);
            }

            private void CreateJounalFile() 
            {
                if (!File.Exists(journalFile))
                {
                    File.CreateText(journalFile);
                }
            }

            private void DisplayIntro() 
            {
                ForegroundColor = ConsoleColor.Black;
                BackgroundColor = ConsoleColor.White;
                Clear();
                Console.WriteLine(TitleArt);
                Console.WriteLine('\nWelcome to the journal app. ');
                WaitForKey();
            }
            
            private void DisplayOutro() 
            {
                ForegroundColor = ConsoleColor.Black;
                BackgroundColor = ConsoleColor.White;
                Console.WriteLine('Thank you for using the journal app. ');
                Console.WriteLine('Program by Julia Merrick');
                Console.WriteLine('\nArt from: https://www.asciiart.eu/books/books')
                WaitForKey(); 
            }

            private void WaitForKey() 
            {
                ForegroundColor = ConsoleColor.DarkGrey;
                Console.WriteLine('Press any key...');
                Console.ReadKey(true):
            }

            private void DisplayJournalContents() 
            {
                ForegroundColor = ConsoleColor.Black;
                BackgroundColor = ConsoleColor.White;
                string journalText = File.ReadAllText(journalFile);
                Console.WriteLine('~~~~ Previous Entries ~~~~');
                Console.WriteLine(journalText);
                Console.WriteLine('~~~~~~~~~~~~~~~~~~~~~~~~~~');
                WaitForKey();
            }

            private void AddEntry() 
            {
                ForegroundColor = ConsoleColor.Black;
                BackgroundColor = ConsoleColor.White;
                Prompt();
                Console.WriteLine(DateTime.Now);
                string newLine = ReadLine();
                WaitForKey();
            }

            private void SaveEntry()
            {
                File.AppendAllText(journalFile, $'>{DateTime.Now} \n{newLine}\n')
                Console.WriteLine('File saved.')
                WaitForKey();
            }

            private void Prompt()
            {
                var random = new Random();
                
                list<string> Prompts = new List<string>();
                Prompts.Add('What are you thankful for today?');
                Prompts.Add('What was the best part of the day?');
                Prompts.Add('What did you accomplish today?');
                Prompts.Add('What was your biggest challenge today?');
                Prompts.Add('What have you tried to change today?');
                int index = random.Next(list.Count);
                Console.WriteLine(list[index]);
                
            }
        }
            
    }
}