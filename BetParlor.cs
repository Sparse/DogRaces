using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogRaces
{
    class BetParlor
    {       
        public int AmountBet;
        public int Dog;
        public Guy Bettor;

        public void GetDescription()
        {
            Bettor.MyTextBox.Text = Bettor.Name + " has bet " + AmountBet.ToString() + " on dog " + Dog;
        }

        public int PayOut(int pWinningDog)
        {
            if (pWinningDog == Dog) return AmountBet * 2;
            else return Bettor.Money - AmountBet;
        }
    }
}
