using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Booking
{
    /// <summary>
    /// Гостиница
    /// </summary>
    struct Hotel
    {
        /// <summary>
        /// Название
        /// </summary>
        public string Name;
        /// <summary>
        /// Город
        /// </summary>
        public string City;
        public string PictureAdress;
        /// <summary>
        /// Фото
        /// </summary>
        public PictureBox pb;
        public Button btn;
        /// <summary>
        /// Рейтинг
        /// </summary>
        public double Rating;

        public Hotel(string _Name, string _City, double _Rating, string _Adress)
        {
            Name = _Name;
            City = _City;
            PictureAdress = _Adress;
            Rating = _Rating;
            btn = new Button();
            btn.Text = Name;
            btn.Size = new Size(250, 40);

            pb = new PictureBox();
            pb.Image = Image.FromFile("../../Pictures/" + PictureAdress);
            pb.SizeMode = PictureBoxSizeMode.StretchImage;
            pb.Size = new Size(250, 150);
        }
    }
}
