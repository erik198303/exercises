using System;

namespace Övning3
{
    class Program
    {
        /*
        ## Övning 3
        Saga med två sträng variabler
-	       Låt användaren mata in två namn. Skriv sedan ut en kort berättelse med dessa två namn.
         */
        static void Main(string[] args)
        {
            System.Console.Write("Skriv ett namn: ");
            string nameOne = Console.ReadLine();
            System.Console.Write("Skriv ytterligare ett namn: ");
            string nameTwo = Console.ReadLine();
            System.Console.WriteLine("{0} och {1} levde lyckliga i alla sina dagar.", nameOne, nameTwo);
        }
    }
}
