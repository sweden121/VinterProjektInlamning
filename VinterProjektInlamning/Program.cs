using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Project_Tamagothci
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Tamagotchi myPet = new Tamagotchi();
            myPet.name = "Mittens";

            while (myPet.GetAlive())
            {
               // denna bit kod displayar tamagotchis stats
                myPet.PrintStats();
               // denna kod tar input från användaren
                Console.WriteLine("Enter a command (feed, hi, teach, quit): ");
                string command = Console.ReadLine();

                if (command == "feed")
                {
                    myPet.Feed();
                }
                else if (command == "hi")
                {
                    myPet.Hi();
                }
                else if (command.StartsWith("teach"))
                {
                    string[] parts = command.Split(' ');
                    if (parts.Length > 1)
                    {
                        myPet.Teach(parts[1]);
                    }
                }
                else if (command == "quit")
                {
                    break;
                }

               // ökar hungern och boredom för varje level/tick
                myPet.Tick();
            }

             Console.WriteLine("Your tamagotchi has died. :(");
            Console.ReadLine();
        }
    }
}
           // så kortfattat så skapar denna del en instance av en tamagotchi class och ger den ett namn
           // Den går också in i en loop som fortsätter så länge tamagotshin är vid liv
           // i varje iteration av en loop så visar den också status av tamagotshin
           // den tar samt användar input och omvandlar till  korrekt metod och ökar hunger och boordom
           // sist men inte minst så avslutas loopen om tamagotshin dör och visar ett meddelandet.