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
            int choice = 0;
            while (choice != 1 && choice != 2)
            {
                Console.WriteLine("Welcome to Banner Parties! A blatant rip-off of MB Bannerlord for the sake of programming practice.");
                Console.WriteLine();
                Console.WriteLine("Main menu");
                Console.WriteLine();
                Console.WriteLine("[1] New game");
                Console.WriteLine();
                Console.WriteLine("[2] Exit game");

                choice = int.Parse(Console.ReadLine());
            }

            return choice;
        }
    }
}
