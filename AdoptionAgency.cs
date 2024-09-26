using adopt_a_fish;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace adopt_a_fish
{
    internal class AdoptionAgency
    {
        public List<fish> fishesToAdopt = new List<fish>();
        Random randomNumberGenerator = new Random();
        

        public AdoptionAgency()
        {
            //string[] name = {"john","twinkie","bob","phillip","bubley","huert","bimtom","wanye","limbarganinni","mundio","zaven","winkababble","doowip","stan","goober" };
            //int indexNumber = randomNumberGenerator.Next(name.Length);
            //fishesToAdopt.Add(
            //    new fish(name[indexNumber])
            //    );

            //we moved this to public void SetUpFishToAdopt() down below here vv

        }
        public void SetUpFishToAdopt()
        {
            string[] name = { "john", "twinkie", "bob", "phillip", "bubley", "huert", "bimtom", "wanye", "limbarganinni", "mundio", "zaven", "winkababble", "doowip", "stan", "goober" };
            //int indexNumber = randomNumberGenerator.Next(name.Length);
            fishesToAdopt = new List<fish>();
            fishesToAdopt.Add(
                new fish(name[randomNumberGenerator.Next(name.Length)])
                );
            fishesToAdopt.Add(
                new fish(name[randomNumberGenerator.Next(name.Length)])
                );
            fishesToAdopt.Add(
                new fish(name[randomNumberGenerator.Next(name.Length)])
                );
            //new fish(name[indexNumber])
            //);
        }

        public string GetFishForAdoption()
        {
            SetUpFishToAdopt();
            string output = "";
            if (fishesToAdopt.Count >0)
            {

                foreach (fish Fish in fishesToAdopt)
                {
                    output += Fish.name + Environment.NewLine;
                    //alternative line... output += $"{Fish.Name}\n;
                }

            }
            else
            {
                output = "oh ok.. no fish for you..";
            }
            return output;
          
        }
    }
}
//List<fish>(); 
// ^^ parentheses indicator of this being a constructor



// vv this can also be done instead for adoption agenecy string

//public AdoptionAgency()
//{
//    string[] name = { "john", "twinkie", "bob", "phillip", "bubley", "huert", "bimtom", "wanye", "limbarganinni", "mundio", "zaven", "winkababble", "doowip", "stan", "goober" };

//    fishesToAdopt.Add(
//        new fish(name[randomNumberGenerator.Next(name.Length)])
//        );

//}
//    }