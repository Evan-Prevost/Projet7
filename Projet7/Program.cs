// See https://aka.ms/new-console-template for more information
//using Projet7;
using System;



class Program
{
    static void Main()
    {
        string state0 = " ► Continue\n   New Game";
        string state1 = "   Continue\n ► New Game";
        int state = 0;
        //Console.WriteLine("Choose a save :\n");
        if (!File.Exists("save"))
        {
            //File.Create("save");
            //Console.WriteLine(" ► New Game");
            Console.WriteLine(state0);
        }
        else
        {
            Console.WriteLine(" ► Continue\n    New Game");
        }
        bool loop = true;
        //while(Console.ReadKey().Key != ConsoleKey.Entre){}
        while (loop) {
            ConsoleKey e = Console.ReadKey().Key;
            switch (e)
            {
                case ConsoleKey.Enter:
                    loop = false;
                    break;
                case ConsoleKey.UpArrow or ConsoleKey.DownArrow:
                    Console.Clear();
                    if (state == 0)
                    {
                        Console.WriteLine(state1);
                        state = 1;
                    }
                    else
                    {
                        Console.WriteLine(state0);
                        state = 0;
                    }
                    break;
                default:
                    break;
            }
        }

    }

}


