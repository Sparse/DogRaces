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

        public void UpdateLabel()
        {
            MyTextBox.Text = this.Name;
        }

        public void PlaceBet(int pAmount, int pDog)
        {
            BetParlor = new BetParlor();
            if (Money == 0) { MessageBox.Show(this.Name + "Says: I don't have enough money to bet!!", "Trying to bet"); return; } 
            if (Money - pAmount > 0) { Money -= pAmount; }
            else { MessageBox.Show(this.Name + "Says: I don't have enough money to bet that much!", "Not enough money"); return; }
            BetParlor.Dog = pDog;
            BetParlor.AmountBet = pAmount;
            BetParlor.Bettor = this;
        }
    }
}
