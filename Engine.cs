using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace adopt_a_fish
{
    public class Engine
    {
        //properties

        player Player1 = new player();
        //  player Player2 = new player();

        AdoptionAgency agency = new AdoptionAgency();


        //methods
        private void ShowMenu() 
        {
            //let player choose an option
            WriteLine("(1) see the fishes in your tank?");
            WriteLine("(2) change your name?");
            WriteLine("(3) name your fish?");
            WriteLine("(4) name your tank?");
            WriteLine("(5) adopt a fish?");
            WriteLine("(6) go to the store to buy supplies like fish food and tanks?");
            WriteLine("(7) exit?");
            Console.WriteLine("enter a number between 1 and 6");

            string input = Console.ReadLine();

            if (input == "7")
            {
                return;
                //Enviornment.exit(0);
            
            }

            if (input == "1") 
            {
                WriteLine(Player1.Tank.Abouttank());
            }
            else if (input == "2")
            {
                Player1.changeplayername();
            }
            else if (input == "5")
            {
                //calling the agency to see what fish they have
                WriteLine(ShowAdoptionAgencyFish());
            }
            else
            {
                Console.WriteLine("coming soon");
            }
            Console.WriteLine("press any key to continue.....");
            ReadKey();
            Console.Clear();
            ShowMenu();
            
        }
        public string ShowAdoptionAgencyFish()
        {
            string output = "the agency for adopting fish tells you they have a few fish here for you to adopt. their names are..\n";
            //access the instance agency and get the list of their fish
            output += agency.GetFishForAdoption();
            return output;
        }
        public void Start()
        {
            Console.Title = "fish adoption time";
            WriteLine("welcome in to the fish taking place. what do you want to do?");
            ShowMenu();
            Console.Beep();





            //Console.WriteLine("Hello, World!");
           
            //WriteLine(Player1.Tank.Abouttank());

            //changing fish's name
            Player1.Tank.Fish.changename(Player1.playername);
            //Player2.Tank.Fish.changename(Player2.playername);

            WriteLine($"{Player1.playername}, your fish's name is {Player1.Tank.Fish.name}. do you want to change it? type y for yes, n for no.");
            string input = ReadLine();
            if (input.ToLower() == "y")
            {
                Player1.Tank.Fish.changename(Player1.playername);

                //    //changing fish's name
                //    Player2.Tank.Fish.changename();
                //    WriteLine($"{Player2.playername} has a fish. it's named {Player2.Tank.Fish.name}.");
                //}

                WriteLine(Player1.Tank.Fish.About());
                //you can also use: string fishinfo = Player1.Tank.Fish.About(); rather than this WriteLine one




                ReadKey();
            }
        }
    }
}
   