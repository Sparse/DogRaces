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
        public NumericUpDown MyDog;
        public RadioButton MyButton;
        public TextBox MyTextBox;
        
        BetParlor BetParlor;


        public void UpdateLabel()
        {

            MyTextBox.Text = this.Name;
        }

        public bool PlaceBet()
        {
            BetParlor.Dog = (int)MyDog.Value;
        }

    }
}
