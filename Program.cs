using System;

namespace SysDesFirstAssignment
{
    class Menu
    {
        static void Main(string[] args)
        {
            char inSelect;

            do
            {
                printMenu();

                inSelect = Char.ToUpper(Char.Parse(Console.ReadLine()));

                Console.WriteLine ("");

                switch(inSelect)
                {
                case 'A':
                    hello();
                    break;
                case 'B':
                    rectangleArea();
                    break;
                case 'C':
                    milesPerGallon();
                    break;
                case 'D':
                    searchAlice();
                    break;
                }

            }while(inSelect != 'Q');

            Environment.Exit(0);
        }

        public static void printMenu()
        {
            Console.WriteLine ("\nChoose an option from the menu below:\n");
            Console.WriteLine ("A) Greeting");
            Console.WriteLine ("B) Area of a Rectangle");
            Console.WriteLine ("C) Fuel Economy");
            Console.WriteLine ("D) String Search\n");

            Console.WriteLine ("Enter Q to quit\n");
        }

        public static void hello()
        {
            Console.WriteLine ("What is your name?");
            string inName = Console.ReadLine();
            //Console.WriteLine ("\nHello " + inName);
            printResponse("Hello " + inName);
        }

        public static void rectangleArea()
        {
            Console.WriteLine ("What is the rectangle's length?");
            double inL = Double.Parse(Console.ReadLine());
            Console.WriteLine ("What is the rectangle's width?");
            double inW = Double.Parse(Console.ReadLine());
            //Console.WriteLine ("\nThe rectangle's area is " + (inL * inW) + " square units");
            printResponse("The rectangle's area is " + (inL * inW) + " square units");
        }

        public static void milesPerGallon()
        {
            Console.WriteLine ("How many miles have you driven?");
            double inMiles = Double.Parse(Console.ReadLine());
            Console.WriteLine ("How many gallons of fuel have you used?");
            double inGallons = Double.Parse(Console.ReadLine());
            //Console.WriteLine ("\nYour fuel economy was " + (inMiles / inGallons) + " miles per gallon.");
            printResponse("Your fuel economy was " + (inMiles / inGallons) + " miles per gallon.");
        }

        public static void searchAlice()
        {
            string firstLine = "Alice was beginning to get very tired of sitting by her sister on the bank, and of having nothing to do: once or twice she had peeped into the book her sister was reading, but it had no pictures or conversations in it, 'and what is the use of a book,' thought Alice 'without pictures or conversation?'";

            Console.WriteLine ("Enter a string to search");
            string inStr = Console.ReadLine();

            if(firstLine.ToLower().IndexOf(inStr.ToLower(), 0, firstLine.Length) != -1)
            {
                //Console.WriteLine ("\nTrue");
                printResponse("True");
            }
            else
            {
                printResponse("False");
                //Console.WriteLine ("\nFalse");
            }
        }

        public static void printResponse(string inText)
        {
            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine ("\n" + inText);

            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}