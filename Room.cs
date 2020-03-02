using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Booking
{
    struct Room
    {
        public string Name;
        public string pictureAdress;
        public int Price;
        public Button btn;
        public PictureBox pb;

        public Room(string _Name, int _Price, string _Adress)
        {
            Name = _Name;
            pictureAdress = _Adress;
            Price = _Price;
            btn = new Button();
            btn.Text = Name;
            btn.Size = new Size(250, 40);

            pb = new PictureBox();
            pb.Image = Image.FromFile("../../Pictures/" + pictureAdress);
            pb.SizeMode = PictureBoxSizeMode.StretchImage;
            pb.Size = new Size(250, 150);
        }
    }
}
