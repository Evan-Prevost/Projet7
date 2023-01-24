// See https://aka.ms/new-console-template for more information
//using Projet7;
using System;


class Program
{
    static void Main()
    {
        Console.WriteLine("Choose a save :\n");
        if (!File.Exists("save"))
        {
            //File.Create("save");
            Console.WriteLine(" ► New Game");
        }
        else
        {
            Console.WriteLine(" ► Continue\n    New Game");
        }
        while (Console.ReadKey().Key != ConsoleKey.Enter) {
            ConsoleKey e = Console.ReadKey().Key;
            switch(e)
            {

                case ConsoleKey.UpArrow:
                    Console.WriteLine("a");
                    break;
                default:
                    Console.WriteLine("a");
                    break;
            }        
        }

    }

}


