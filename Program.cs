using System;

namespace Program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String input = Console.ReadLine();
            int UserChoice = int.Parse(input);
            switch (UserChoice)
            {
                case 1:
                    Console.WriteLine("Creating Student");
                    break;
                
                case 2:
                    Console.WriteLine("Creating Teacher");
                    break;

                case 3:
                    Console.WriteLine("Creating Lesson");
                    break;

                default:
                    Console.WriteLine("NUH UH");
                    break;
                
            }

            Console.WriteLine("wsg");
        }
    }
}