
using System;

namespace Recording
{
    internal class ChatBot
    {
        public ChatBot()
        {
        }

        internal void StartChat()
        {
            Console.WriteLine("Hello! Welcome to the YangaCY Awareness Bot.");
            Console.WriteLine("I am here to help you learn about cybersecurity.");
            Console.WriteLine();

            Console.Write("What is your name? ");
            string name = Console.ReadLine();

            while (string.IsNullOrWhiteSpace(name))
            {
                Console.WriteLine("Please enter your name.");
                Console.Write("What is your name? ");
                name = Console.ReadLine();
            }

            Console.WriteLine();
            Console.WriteLine("Nice to meet you, " + name + "!");
            Console.WriteLine();

            Console.WriteLine("What would you like to learn about?");
            Console.WriteLine("1. Phishing");
            Console.WriteLine("2. Password Safety");
            Console.WriteLine("3. Cyberbullying");
            Console.WriteLine("4. Online Privacy");

            Console.Write("Please choose 1, 2, 3 or 4: ");
            string choice = Console.ReadLine();

            if (choice == "1")
            {
                Console.WriteLine();
                Console.WriteLine("Phishing is when someone tries to trick you into giving");
                Console.WriteLine("away personal information, passwords or banking details.");
                Console.WriteLine("Always check links and the sender before clicking.");
            }
            else if (choice == "2")
            {
                Console.WriteLine();
                Console.WriteLine("Password Safety:");
                Console.WriteLine("Use strong and unique passwords.");
                Console.WriteLine("Do not share your passwords with other people.");
                Console.WriteLine("Enable two-factor authentication when possible.");
            }
            else if (choice == "3")
            {
                Console.WriteLine();
                Console.WriteLine("Cyberbullying is bullying that happens online.");
                Console.WriteLine("Do not respond to harmful messages.");
                Console.WriteLine("Block and report the person and tell someone you trust.");
            }
            else if (choice == "4")
            {
                Console.WriteLine();
                Console.WriteLine("Online Privacy:");
                Console.WriteLine("Do not share personal information with strangers.");
                Console.WriteLine("Be careful about what you post online.");
                Console.WriteLine("Check your privacy settings regularly.");
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("Sorry, I don't understand that choice.");
                Console.WriteLine("Please choose a number from 1 to 4.");
            }

            Console.WriteLine();
            Console.WriteLine("Thank you for using the YangaCY Awareness Bot, " + name + "!");
        }
    }
}