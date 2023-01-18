using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Project_Tamagothci
{
    public class VirtualPet<T>
    {
      
        protected int hunger;
     
        protected int boredom;
      

           private bool isAlive;



                   public VirtualPet()
        {
           
            generator = new Random();
            isAlive = true;
        }



                public void Feed()
        {
            Console.WriteLine($" [{name}] eats and becomes less hungry");
            hunger--;
            if (hunger < 0)
            {
                hunger = 0;
            }
        }

        public void Tick()
        {
            hunger++;
            boredom++;
            if (hunger > 10 || boredom > 10)
            {
                isAlive = false;
            }
        }

public void PrintStats()
        {
            Console.WriteLine($"Name: {name} Hunger: {hunger} Boredom: {boredom}");
        }



