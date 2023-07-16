using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 100);
        
        int guess = -1
        while (guess != magicNumber)
        {
           Console.Write("What's the magic number? ")
           guess = int.Parse(Console.ReadLine()) 

           if (guess > magicNumber)
           {
            Console.Write("Lower.")
           }

           else if (guess < magicNumber)
           {
            Console.Write("Higher.")
           }

           else
           {
            Console.Write("You got it! ")
           }
        }
    }
}