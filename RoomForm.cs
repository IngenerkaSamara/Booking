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
    public partial class RoomForm : Form
    {
        public RoomForm(string Name, int Price)
        {
            InitializeComponent();
            nameLabel.Text = Name;
            priceLabel.Text = "Цена " + Price.ToString() + " рублей";
        }

        private void RoomForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OrderForm of = new OrderForm();
            of.Show();
        }
    }
}
