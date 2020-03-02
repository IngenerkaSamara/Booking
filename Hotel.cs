using System;
using System.Collections.Generic;
using System.Linq;
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
        /// <summary>
        /// Фото
        /// </summary>
        public PictureBox Picture;
        /// <summary>
        /// Рейтинг
        /// </summary>
        public double Rating;

        public Hotel(string _Name, string _City, PictureBox _Picture, double _Rating)
        {
            Name = _Name;
            City = _City;
            Picture = _Picture;
            Rating = _Rating;
        }
    }
}
