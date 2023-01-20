using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Tamagothci
{
    public class Tamagotchi : VirtualPet<Tamagotchi>
    {
       // listan av ord tamagotshin kan säga
        private List<string> words = new List<string>() { "Hewwo" };

         // här så gör den tamagotshin säga ett ord från sin vocubelär 
        public void Hi()
        {
            int wordNum = generator.Next(words.Count);
            Console.WriteLine($" [{name}] says: {words[wordNum]}");
            ReduceBoredom();
        }

       // lär ut tamagotshin ett nytt ord
        public void Teach(string word)
        {
            Console.WriteLine($" [{name}] learns: {word}");
            words.Add(word);
            ReduceBoredom();
        }

        // den overridar printstats metoden för att inkludera tamagotshins vocabulär
        public new void PrintStats()
        {
            Console.WriteLine($"Name: {name} Hunger: {hunger} Boredom: {boredom} Vocabulary: {words.Count} words");
        }
    }
}

// denna del av koden så är Virtual pet en generic class och tamagotchin är inherited från den
// Tamagotshin classen overidar printstats metoden för att includera tamagotshins vocabulär