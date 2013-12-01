using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DogRaces
{
    class Guy
    {
        public string Name;
        public int Money;        
        public Label MyLabel;
        public RadioButton MyButton;
        public TextBox MyTextBox;
        BetParlor BetParlor;

        public bool AlreadyBet = false;
        int AmountBet;
       
        public void UpdateLabel()
        {
            if (!AlreadyBet)
            {
                MyButton.Text = Name + " has " + Money.ToString() + " dollars";
            }
            else
            {
                BetParlor.GetDescription();
                MyButton.Text = Name + " has " + Money.ToString() + " dollars";
            }
        }

        public void PlaceBet(int pAmount, int pDog)
        {
            if (AlreadyBet)
            {
                Money += AmountBet;
                AmountBet = 0;
                AlreadyBet = false;
            }

            if (Money <= 0) 
            { 
                MessageBox.Show(this.Name + "Says: I don't have enough money to bet!!", "Trying to bet"); 
                return; 
            } 

            if (Money - pAmount > 0) 
            { 
                Money -= pAmount; 
            }
            else 
            { 
                MessageBox.Show(this.Name + "Says: I don't have enough money to bet that much!", "Not enough money"); 
                return; 
            }

            AlreadyBet = true;
            AmountBet = pAmount;
            BetParlor = new BetParlor() { Dog = pDog, AmountBet = pAmount, Bettor = this };
        }

        public void Collect(int pWinner)
        {
            Money = BetParlor.PayOut(pWinner);
            MyButton.Text = Name + " has " + Money.ToString() + " dollars";
        }
    }
}
