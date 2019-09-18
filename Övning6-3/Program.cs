using System;

namespace Övning6_3
{
    class Program
    {   
        /*
        Kontrollera värdet (del 3)
-	Arbeta vidare på övningen. 
Gör så att om användaren matar in något annat än ”J”, ”j”, ”n”, ”N” så skriver programmet ut ”Jag förstår inte!”.
         */
        static void Main(string[] args)
        {
            System.Console.WriteLine("Är det fint väder ute? J/N");
            string weather = Console.ReadLine();

            if(weather == "J" || weather == "j")
            {
                System.Console.WriteLine("Vi går på picknick");
            }
            else if(weather == "N" || weather == "n" )
            {
                System.Console.WriteLine("Vi stannar inne");
            }
            else
            {
                System.Console.WriteLine("Jag förstår inte!");
            }
        }
    }
}
