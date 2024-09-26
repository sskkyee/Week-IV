using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;

namespace adopt_a_fish
{
    public class player
    {
        //private int IDNumber;
        //private int IDNumber = 0;

        public string playername = "mystery player";
        //containment example The Player "has a" tankk
        public tank Tank = new tank();
        public int FishFood = 10;

        public void FeedFish()
        {
            if (FishFood > 0)
            {
                FishFood--;
            }
        }

        public player(string name) //this is a constructor, it has no return type
        {
            playername = name;
        }
        public player()
        {
            changeplayername();
        }

        public void changeplayername()
        {
            //changing player's name
            WriteLine($"what name do you want {playername}?");
            playername = ReadLine();
            WriteLine($"ok, nice to meet you {playername}.");
        }
     
    }
}