using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DogRaces
{
    public partial class Form1 : Form
    {
        public bool Winner = false;
        public bool RaceOver = false;
        Greyhound[] NewGreyHound;
        Guy[] NewGuy;
        
        
        public Form1()
        {
            InitializeComponent();       
 
            NewGuy = new Guy[] 
            { new Guy() { Money = 50, Name = "Joe", MyButton = radioButton1, MyTextBox = textBox1 }, 
              new Guy() { Money = 75, Name = "Bob", MyButton = radioButton2, MyTextBox = textBox2 }, 
              new Guy() { Money = 45, Name = "Al", MyButton = radioButton3, MyTextBox = textBox3 } };

            NewGreyHound = new Greyhound[]
            { new Greyhound() { MyPictureBox = pictureBox1, LocationX = 0, RaceTrackLength = pictureBox5.Right, Name = "Dog1" },
              new Greyhound() { MyPictureBox = pictureBox2, LocationX = 0, RaceTrackLength = pictureBox5.Right, Name = "Dog2" },
              new Greyhound() { MyPictureBox = pictureBox3, LocationX = 0, RaceTrackLength = pictureBox5.Right, Name = "Dog3" },
              new Greyhound() { MyPictureBox = pictureBox4, LocationX = 0, RaceTrackLength = pictureBox5.Right, Name = "Dog4" } };

            Array.ForEach(NewGuy, guy => guy.UpdateLabel());
            Array.ForEach(NewGreyHound, a => a.ToStartLine());
        }

        public void button1_Click(object sender, EventArgs e)
        {
            if (RaceOver) { RestartRace(); }

            while (Winner == false)
            {
                if (BetParlor.AllBetsPlaced)
                {
                    for (int i = 0; i < NewGreyHound.Length; ++i)
                    {
                        NewGreyHound[i].Run();
                        pictureBox5.Refresh();
                        if (NewGreyHound[i].Run())
                        {
                            bool allequal = NewGreyHound.Skip(1).Count(g => g.LocationX == NewGreyHound[0].LocationX) == NewGreyHound.Length - 1;
                            Winner = true;
                            RaceOver = true;
                            if (allequal) { MessageBox.Show("Holy shit! A draw!! Everyone wins money!!"); }

                            MessageBox.Show("We have a winner! It's " + NewGreyHound[i].Name);
                            Array.ForEach(NewGreyHound, m => m.ToStartLine());
                            BetParlor.AllBetsPlaced = false;                            
                            break;
                        }
                    }
                }
                else { MessageBox.Show("All bets need to be placed before the race can begin!!"); break; }
            }
        }
        public void RestartRace()
        {
            Array.ForEach(NewGreyHound, a => a.ToStartLine());
            RaceOver = false;
            Winner = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }
    }
}
