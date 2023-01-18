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

                myPet.PrintStats();

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


                myPet.Tick();
            }

             Console.WriteLine("Your tamagotchi has died. :(");
            Console.ReadLine();
        }
    }
}