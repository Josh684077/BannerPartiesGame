using System;

namespace BannerPartiesUI
{
    class Program
    {
        static void Main(string[] args)
        {
            Program myProgram = new Program();
            myProgram.Start();
        }

        void Start()
        {
            MainMenu();
            Console.ReadKey();
        }

        int MainMenu()
        {
            Console.WriteLine("Welcome to Banner Parties! A blatant rip-off of MB Bannerlord for the sake of practice.");
            Console.WriteLine();
            Console.WriteLine("Main menu");
            Console.WriteLine();
            Console.WriteLine("[1] New game");
            Console.WriteLine();
            Console.WriteLine("[2] Exit game");

        }
    }
}
