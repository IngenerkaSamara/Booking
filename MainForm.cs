using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Booking
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            RegisterForm rf = new RegisterForm();
            rf.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
        {
            HotelForm hf = new HotelForm();
            hf.Show();
        }
    }
}
