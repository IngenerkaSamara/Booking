using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace Booking
{
    public partial class HotelForm : Form
    {
        List<Room> rooms_list = new List<Room>();

        public HotelForm(string Name, string City)
        {
            InitializeComponent();
            Text = "Гостиница " + Name;
            cityLabel.Text = City;

            //Чтение из файла
            int x = 0;
            string[] lines_list = File.ReadAllLines("../../Room.txt");
            foreach (string line in lines_list)
            {
                string[] line_parts = line.Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries);
                Room room = new Room(line_parts[0], Convert.ToInt32(line_parts[1]), line_parts[2]);
                room.btn.Location = new System.Drawing.Point(x, 240);
                room.pb.Location = new System.Drawing.Point(x, 280);
                room.btn.Click += new EventHandler(button1_Click);
                room.pb.Click += new EventHandler(button1_Click);
                x = x + 260;

                rooms_list.Add(room);
                Controls.Add(room.btn);
                Controls.Add(room.pb);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (Room room in rooms_list)
            {
                if (sender.Equals(room.btn) ||
                    sender.Equals(room.pb))
                {
                    RoomForm rf = new RoomForm(room.Name, room.Price);
                    rf.Show();
                    break;
                }
            }
        }

        private void HotelForm_Load(object sender, EventArgs e)
        {

        }
    }
}
