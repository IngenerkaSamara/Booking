﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Booking
{
    public partial class MainForm : Form
    {
        List<Hotel> hotel_list = new List<Hotel>();

        public MainForm()
        {
            InitializeComponent();

            //Чтение из файла
            int x = 0;
            string[] lines_list = File.ReadAllLines("../../Hotel.txt");
            foreach (string line in lines_list)
            {
                string[] line_parts = line.Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries);
                Hotel hotel = new Hotel(line_parts[0], line_parts[1], Convert.ToDouble(line_parts[2]), line_parts[3]);
                hotel.btn.Location = new System.Drawing.Point(x, 10);
                hotel.pb.Location = new System.Drawing.Point(x, 50);
                hotel.btn.Click += new EventHandler(button1_Click);
                hotel.pb.Click += new EventHandler(button1_Click);
                x = x + 260;

                hotel_list.Add(hotel);
                hotelsPanel.Controls.Add(hotel.btn);
                hotelsPanel.Controls.Add(hotel.pb);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            RegisterForm rf = new RegisterForm();
            rf.ShowDialog();
        }

        private void showFilter_Click(object sender, EventArgs e)
        {
            if (tableLayoutPanel1.RowStyles[1].Height > 80)
            {
                tableLayoutPanel1.RowStyles[1].Height = 0;
            }
            else
            {
                tableLayoutPanel1.RowStyles[1].Height = 100;
            }
        }

        /// <summary>
        /// Открытие гостиницы в новом окне
        /// </summary>
        private void button1_Click(object sender, EventArgs e)
        {
            foreach (Hotel hotel in hotel_list)
            {
                if (sender.Equals(hotel.btn) ||
                    sender.Equals(hotel.pb))
                {
                    HotelForm rf = new HotelForm(hotel.Name, hotel.City);
                    rf.Show();
                    break;
                }
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
