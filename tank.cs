using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace adopt_a_fish
{
    public class tank
    {
        public fish Fish = new fish();
        public List<fish> fishes = new List<fish>();
        //private string input;

        public tank()
        {
            fishes.Add(new fish("brim"));
            fishes.Add(new fish("pari"));
        }
        public string Abouttank() 
        {
            string output = "Fishes in this random tank:\n";

            foreach (fish Fish in fishes) 
            {
                output += $" *  {Fish.name} {Environment.NewLine}";
            }


            return output;
        
        }
    }
}