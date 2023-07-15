using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter grade: ");
        string grade = Console.ReadLine();
        
        int x = int.Parse(grade);

        if (x >= 90)
        {
            Console.WriteLine("Your grade is an A.");
        }
        else if (x <= 89 && x >= 80)
        {
            Console.WriteLine("Your grade is a B.");
        }
        else if (x <= 79 && x >= 70)
        {
            Console.WriteLine("Your grade is a C.");
        }
        else if (x <= 69 && x >= 60)
        {
            Console.WriteLine("Your grade is a D.");
        }
        else 
        {
            Console.WriteLine("Your grade is an F.");
        }
    }
}