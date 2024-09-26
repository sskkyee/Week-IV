//container providing context for class within it

/*
 * adopt a fish
 * Skye Pratt
 * 9/5
 */

//using static System.Console;

using adopt_a_fish;

namespace adopt_a_fish
{
    class Program
    {

        //app starts here
        static void Main()
        {
            Engine engine = new Engine();
            engine.Start();

            //new Engine().Start();
        }
    }
}














//writing notes/previous comments here because I don't want to lose them but I also don't want them to take up space anywhere else

//console is a class, write line is a method

//player Player1 = new player("player1");
// player Player2 = new player();


//Player1.Tank.Abouttank();
//concatentation
//WriteLine("player one has this fish. it's name is " + Player1.Tank.Fish.name + "!");
//WriteLine(4 + 9);
//WriteLine("4+9");
//WriteLine("4" + "9");

//WriteLine($"player one has this fish. it's name is {Player1.Tank.Fish.name}!");

//interpolation

//    //changing fish's name
//    Player2.Tank.Fish.changename();
//    WriteLine($"{Player2.playername} has a fish. it's named {Player2.Tank.Fish.name}.");
//}


//WriteLine(Player1.Tank.Fish.About());
//you can also use: string fishinfo = Player1.Tank.Fish.About(); rather than this WriteLine one
