using static System.Console;

namespace adopt_a_fish
{
    public class fish
    {
        public string name;
        public string color;
        public string type;
        public int HungerLevel = 10;

        public fish(string fishname)
        {
            // name = "birm";
            name = fishname;
            color = "orange";
            type = "cichild";
        
        }

        public fish() { }

        public void sleep() 
        { 
        
        
        }

        public void eat() 
        {
            if (HungerLevel == 0)
            {
                //fish isn't hungry and won't eat
            }
            else
            {
                HungerLevel--;
            }
            //HungerLevel = HungerLevel - 1;
            //HungerLevel = -HungerLevel;
        
        
        }

        public void swim() 
        {


        }
        
        public void changename(string playername)
        {
            WriteLine($"{playername}, what name do you want for your fish?");
            string input = ReadLine();

            if (input == "") //|| input.Length > 225)
            {
                name = "default fish name";
            }
            else
            {
                name = input;
            }


        }
        //logic only
        public string About()
        {
            string output = "fish data for player1: \n";
            output += $"the fish name is {name}\n";
            output += $"the color of the fish is {color} and the breed of fish is {type}";


            return output;

        }
          

  
    }
}