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
        public string Adress;
        public int Price;
        public Button btn;
        public PictureBox pb;

        public Room(string _Name, int _Price, string _Adress)
        {
            Name = _Name;
            Adress = _Adress;
            Price = _Price;
            btn = new Button();
            btn.Text = Name;
            btn.Size = new Size(250, 40);

            pb = new PictureBox();
            pb.Image = Image.FromFile("../../Pictures/" + Adress);
            pb.SizeMode = PictureBoxSizeMode.StretchImage;
            pb.Size = new Size(250, 150);
        }
    }
}
