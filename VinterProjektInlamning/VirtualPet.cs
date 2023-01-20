using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Tamagothci
{
    public class VirtualPet<T>
    {
     // hungern leveln
        protected int hunger;
     // boredom leveln
        protected int boredom;
       
        // kollar om den är vid liv eller inte
        private bool isAlive;
       // namnet på den 
        protected Random generator;
        
        public string name;

        public VirtualPet()
        {
            // startar random nuber generatorn
            generator = new Random();
            isAlive = true;
        }

         // matar den virtuella pet och sänker den hunger level
        public void Feed()
        {
            Console.WriteLine($" [{name}] eats and becomes less hungry");
            hunger--;
            if (hunger < 0)
            {
                hunger = 0;
            }
        }

        // denna bit kollar om den är vid liv samt ökar hunger och boredom
        public void Tick()
        {
            hunger++;
            boredom++;
            if (hunger > 10 || boredom > 10)
            {
                isAlive = false;
            }
        }

        // printar ut dens namn hunger och booredom level
        public void PrintStats()
        {
            Console.WriteLine($"Name: {name} Hunger: {hunger} Boredom: {boredom}");
        }

        // kollar om den är vid liv
        public bool GetAlive()
        {
            return isAlive;
        }

        // sänker booredom
        public void ReduceBoredom()
        {
            Console.WriteLine($" [{name}] is now less bored!");

            boredom -= 2;
            if (boredom < 0)
            {
                boredom = 0;
            }
        }
    }
}