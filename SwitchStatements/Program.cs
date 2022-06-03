using System;

namespace SwitchStatements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console asks for subject and writes it to var userInput
            Console.WriteLine("What is you favorite subject in school?");
            string userInput = Console.ReadLine();
            //Switch takes input, lowercases it and runs it through a switch
            switch (userInput.ToLower())
            {
                case "programming":
                    Console.WriteLine("Sounds like you're a TrueCoder!");
                    break;
                case "lunch":
                    Console.WriteLine("Yeah, me too.");
                    break;
                case "gym":
                    Console.WriteLine("Take a lap.");
                    break;
                case "math":
                    Console.WriteLine("That just doesn't add up.");
                    break;
                case "science":
                    Console.WriteLine("Very interesting...");
                    break;
                default:
                    Console.WriteLine("I was running out of clever things to say anyway.");
                    break;
            }
        }
    }
}
