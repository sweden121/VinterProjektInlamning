using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


 namespace Project_Tamagothci
{
    public class Tamagotchi : VirtualPet<Tamagotchi>
    {
      
        private List<string> words = new List<string>() { "Hewwo" };

       
        public void Hi()
        {
            int wordNum = generator.Next(words.Count);
            Console.WriteLine($" [{name}] says: {words[wordNum]}");
            ReduceBoredom();
        }

        public void Teach(string word)
        {
            Console.WriteLine($" [{name}] learns: {word}");
            words.Add(word);
            ReduceBoredom();
        }

 public new void PrintStats()
        {
            Console.WriteLine($"Name: {name} Hunger: {hunger} Boredom: {boredom} Vocabulary: {words.Count} words");
        }
    }