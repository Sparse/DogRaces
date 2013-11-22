using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogRaces
{
    class BetParlor
    {
        public static bool AllBetsPlaced = true;
        public int AmountBet;
        public int Dog;
        public Guy Bettor;

        public void GetDescription()
        {
            string toreturn = Bettor.Name + "has bet " + AmountBet.ToString() + "dog " + Dog;
        }

        public void PayOut()
        {

        }
    }
}
