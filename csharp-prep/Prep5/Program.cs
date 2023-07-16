using System;

class Program
{
    static void Main(string[] args)
    {
       DisplayWelcomeMessage();

        string userName = PromptUserName();
        int userNumber = PromptUserNumber();

        int squaredNumber = SquareNumber(userNumber);

        DisplayResult(userName, squaredNumber); 
    }

    static void DisplayMessage()
        {
            Console.ReadLine("Welcome to the Program.");
        }

    static void PromptUserName()
        {
            Console.Write("What's your name? ")
            string name = Console.ReadLine();

            return name;
        }

    static void PromptUserNumber()
        {
            Console.Write("What is your favorite number? ")
            number = int.Parse(Console.ReadLine())

            return number;
        }

    static void SquareNumber()
        {
            int square = number * number;
            return square;
        }
    static void DisplayResult(string name, int square)
        {
            Console.WriteLine($"{name}, the square of your number is {square}");
        }
}