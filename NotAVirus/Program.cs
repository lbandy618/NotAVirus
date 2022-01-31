using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Intro
            Console.WriteLine("Welcome to the metaverse noob.");
            Console.WriteLine("You will now be asked some very basic info for no apparent reason.");
            Console.WriteLine();

            // Getting info
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            Console.WriteLine("What is your favorite food?");
            string food = Console.ReadLine();
            Console.WriteLine("What is your mothers maiden name?");
            string maidenName = Console.ReadLine();
            Console.WriteLine("What is your currnet home address?");
            string address = Console.ReadLine();
            Console.WriteLine( );

            Console.WriteLine("Now, please type your bank's name followed by enter, then type your credit card number for ");
            Console.WriteLine("the simple processing transaction.");
            string bankName = Console.ReadLine();
            double cardNumber = double.Parse(Console.ReadLine());
            Console.WriteLine("Lastly, all I will need is just your social security number, thanks!");
            string social = Console.ReadLine();
            Console.WriteLine();

            //Displaying stolen info
            Console.WriteLine("Thank you for the info " + name);
            Console.WriteLine();
            Console.WriteLine("I will make sure to have Ms." + maidenName + " serve you " + food + " tonight at " + address + "." );
            Console.WriteLine();
            Console.WriteLine("You will then recieve a call from " + bankName + " letting you know that " + cardNumber + " as well as " + social);
            Console.WriteLine("have both been compromised and you have definitely gotten trolled noob.");
        }
    }
}