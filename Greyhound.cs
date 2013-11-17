using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace DogRaces
{
    class Greyhound
    {
        
        public int StartingPosition;
        public int RaceTrackLength;
        public PictureBox MyPictureBox = null;
        public int LocationX;
        private static Random Rand = new Random();
        public string Name;

        public bool Run()
        {
            MoveDog(Rand.Next(1, 4));
            if (MyPictureBox.Right >= RaceTrackLength - 1) { return true; } else return false;
        }

        public void ToStartLine()
        {
            MyPictureBox.Location = new Point(StartingPosition, MyPictureBox.Location.Y);
        }

        public int MoveDog(int pDistance)
        {
            this.MyPictureBox.Location = new Point(this.MyPictureBox.Location.X + pDistance, this.MyPictureBox.Location.Y);
            LocationX = this.MyPictureBox.Location.X;
            return pDistance;
        }
    }
}
