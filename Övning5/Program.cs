using System;

namespace Övning5
{
    class Program
    {
        /*
        ## Övning 5

        Inmatning och utmatning 
	    -I denna övning ska du göra ett program som låter användaren mata in sitt namn. Därefter hälsar du användaren välkommen.
         Du ska sedan låta användaren mata in sin ålder och spara undan den i lämplig variabel. 
        Räkna sedan ut antalet dagar användaren har levt utifrån det angivna åldern. Presentera detta för användaren.
         */
        static void Main(string[] args)
        {
            System.Console.Write("Skriv ditt namn: ");
            string name = Console.ReadLine();
            System.Console.WriteLine("Hej {0}!", name);
            System.Console.Write("Hur gammal är du: ");
            int age = Convert.ToInt32(Console.ReadLine());
            System.Console.WriteLine("{0} är {1} år gammal och har levt i {2}", name,age, (age*365));


        }
    }
}
